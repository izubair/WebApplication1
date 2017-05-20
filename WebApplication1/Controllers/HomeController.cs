using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment environment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            environment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Error()
        {
            return View();
        }
        
        [Authorize]
        public IActionResult Home()
        {
            //ViewData["Message"] = "Your contact page.";

            //return View();
            return PhysicalFile(Path.Combine(environment.ContentRootPath, "Home", "index.html"), "text/html");
        }

    }

}

