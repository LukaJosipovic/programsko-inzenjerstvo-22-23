using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIProjekt.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace PIProjekt.Controllers
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
        [HttpPost]
        public IActionResult Work(IFormCollection form)
        {
            Employee employee = new Employee();
            employee.Username = form["username"];
            employee.Password = form["password"];

            if ((employee.Username == "Zaposlenik1" && employee.Password == "1234") || (employee.Username == "Zaposlenik2" && employee.Password == "12345"))
            {

                var vehicleTypeList = new List<string>() { "Automobil", "Kombij", "Autobus", "Kamion" };
                var fuelTypeList = new List<string>() { "Gas", "Electric" };

                ViewBag.VehicleTypeList = vehicleTypeList;
                ViewBag.FuelTypeList = fuelTypeList;

                return View(employee);
            }
            else
            {
                return Unauthorized();
            }
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
    }
}