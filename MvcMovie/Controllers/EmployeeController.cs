using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Vivek", Eid = 1 });
            employees.Add(new Employee { Name = "yogesh", Eid=2 });
            employees.Add(new Employee { Name= "Kartik",Eid=3 });
            return View(employees);
        }
            
            
        }
    }
