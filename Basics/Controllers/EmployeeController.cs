using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers {
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }

        public ViewResult Index2() 
        {
            return View("Index");
        }

        public ViewResult Result() {
            return View();
        }

        public IActionResult Content() {
            return Content("This is a content!");
        }

        public ViewResult ModelExample1()
        {
            //Model string olarak verilecek ise View ismininde verilemesi zorunlu
            string stringModel = $"Date of Today: {DateTime.Today.Date}";
            return View("ModelExample1", stringModel);
        }

        public ViewResult ModelExample2() 
        {
            var names = new String[]
            {
                "Name1",
                "Name2",
                "Name3",
                "Name4"
            };
            return View(names);
        }

        public IActionResult ListEmployee() 
        {
            var employees = new List<Employee> 
            {
                new Employee { Id = 1, FirstName = "Name1", LastName = "LastName1", Age= 21},
                new Employee { Id = 2, FirstName = "Name2", LastName = "LastName2", Age= 22},
                new Employee { Id = 3, FirstName = "Name3", LastName = "LastName3", Age= 23},
            };
            return View("List", employees);
        } 
    }
}