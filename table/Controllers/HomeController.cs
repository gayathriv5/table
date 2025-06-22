using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using table.Models;


namespace Table.Controllers
{
    public class HomeController : Controller
    {
        List<Contact> contacts = new List<Contact>
        {
            new Contact{Name="Gayathri",Location="kottayam"},
            new Contact{Name="aarya",Location="pala"}
        };

        public IActionResult Index()
        {
            ViewBag.contacts = contacts;
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
    }
}