using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Core2.Models;
using Core2.BusinessLogic;

namespace Core2.Controllers
{
    public class HomeController : BaseController
    {
        Service service = new Service(); //need constructor



        public IActionResult Index()
        {
            var vModel = service.GetIndexViewModel();
            return View(vModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
