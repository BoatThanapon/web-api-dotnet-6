using System.Net;
using IIGApi.Models.Dto;
using IIGApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IIGApi.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly iiGContext _context = new iiGContext();

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Gets()
        {
            var customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(long id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound("Customer Not Found");
            }

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                Firstname = customerDto.Firstname,
                Lastname = customerDto.Lastname,
                Email = customerDto.Email,
                MobilePhone = customerDto.MobilePhone,
                Age = customerDto.Age
            };

            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();

            return StatusCode(((int)HttpStatusCode.Created));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(long id, CustomerDto customerDto)
        {
            Customer customer = new Customer
            {
                Id = id,
                Firstname = customerDto.Firstname,
                Lastname = customerDto.Lastname,
                Email = customerDto.Email,
                MobilePhone = customerDto.MobilePhone,
                Age = customerDto.Age
            };

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}