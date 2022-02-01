using System;
using System.Collections.Generic;

namespace IIGApi.Models.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? MobilePhone { get; set; }
        public int? Age { get; set; }
    }
}
