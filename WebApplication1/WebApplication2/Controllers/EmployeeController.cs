using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Show(string firstname)
        {
            if (string.IsNullOrEmpty(firstname))
            {
                ViewData["ErrorMessage"] = "No firstname provided!";
            }
            else
            {
                Employee employee = new Employee
                {
                    FirstName = firstname,
                    LastName = "Example",
                    Email = firstname + "@example.com"
                };

                ViewData["FirstName"] = employee.FirstName;
                ViewData["LastName"] = employee.LastName;
                ViewData["Email"] = employee.Email;
            }
            return View();

        }
    }
}