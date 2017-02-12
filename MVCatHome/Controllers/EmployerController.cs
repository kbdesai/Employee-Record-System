using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCatHome.Models;

namespace MVCatHome.Controllers
{
    public class EmployerController : Controller
    {

        public ActionResult Department()
        {
            EmployeeContext deptlist = new EmployeeContext();
            List<Department> Deplist = deptlist.Departments.ToList();
            return View(Deplist);
        }

        public ActionResult Index(Int64 dptid)
        {
           
            EmployeeContext emplrlist = new EmployeeContext();
            List<Employer> Emplist = emplrlist.Employers.Where(w=> w.DepartmantID == dptid).ToList();
            return View(Emplist);
        }

        public ActionResult Details(Int64 Id)
        {
            EmployeeContext emplr = new EmployeeContext();
            Employer Emp = emplr.Employers.Single(e => e.ID == Id);
            return View(Emp);
        }
    }
}