using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCatHome.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=MVC_constrg")
             {

             }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}