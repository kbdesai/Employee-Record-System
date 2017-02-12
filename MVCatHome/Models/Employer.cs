using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCatHome.Models
{
    [Table("tblEmployer")]
    public class Employer
    {
        public Int64 ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public Int64 DepartmantID { get; set; }
    }

    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        public Int64 DepartmantID { get; set; }       
        public String DepartmentName { get; set; }
        public List<Employer> Empslist { get; set; }
       
    }
}