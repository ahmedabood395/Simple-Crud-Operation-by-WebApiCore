using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiCore.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }
        public string Address { get; set; }
    }
}
