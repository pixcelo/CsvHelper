using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CsvHelperApp.Models;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;

namespace CsvHelperApp.Controllers
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

            //List<Product> p = new List<Product>()

            ViewData["Product"] = new Product()
            {
                Id = 1,
                Name = "Pen",
                Price = 300,
            };

            return View();
        }

        public IActionResult ReadCsv()
        {

            using (var reader = new StreamReader("/Users/tetsu/user.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<User>();
                

                foreach(var data in records)
                {
                    ViewData["Records"] = data.Name;
                }

                // 　表示されない
                // ViewBag.record = records;


            }


            ViewData["Message"] = "Your application description page.";

            return View();
        }



[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
