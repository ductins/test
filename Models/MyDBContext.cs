using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DAHQTCSDL.Models
{
    public class MyDBContext:DbContext
    {
        public MyDBContext():base("myCS"){}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}