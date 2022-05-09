using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ITOrganizations()
        {
            return View(new List<string>
            {
                "www.microsoft.com", "www.cognizant.com", "Google", "Amazon", "TCS"
            });
        }

        public IActionResult GetEmployeeList()
        {
            string? blob = System.IO.File.ReadAllText("Data/Employee.json");
            IEnumerable<Employee> employees = JsonSerializer.Deserialize<IEnumerable<Employee>>(
                blob,
                new JsonSerializerOptions(JsonSerializerDefaults.Web)
            )!;
            return View(employees);
        }
    }
}