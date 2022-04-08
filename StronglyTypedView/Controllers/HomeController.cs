using StronglyTypedView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employees emp = new Employees();

            emp.Id = 1;
            emp.Name = "Usman";
            emp.Designation = "employee";

            Employees emp2 = new Employees();

            emp2.Id = 1;
            emp2.Name = "Usman";
            emp2.Designation = "employee";

            Employees emp3 = new Employees();

            emp3.Id = 1;
            emp3.Name = "Usman";
            emp3.Designation = "employee";

            //ViewBag.empdata = emp;
            //ViewData["empdata"] = emp;

            List<Employees> employeeslist = new List<Employees>();
            employeeslist.Add(emp);
            employeeslist.Add(emp2);
            employeeslist.Add(emp3);

            return View(employeeslist);
        }
    }
}