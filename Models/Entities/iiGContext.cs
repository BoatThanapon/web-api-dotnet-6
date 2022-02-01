using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IIGApi.Models.Entities
{
    public partial class iiGContext : DbContext
    {
        public iiGContext(DbContextOptions<iiGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
