using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JanuszJusiak.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace JanuszJusiak.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRazorViewEngine _razorViewEngine;

        public HomeController(IRazorViewEngine razorViewEngine)
        {
            _razorViewEngine = razorViewEngine;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All(string viewName, string controllerName)
        {

            string viewPath = $"../{controllerName}/{viewName}";

            if (ViewExists(viewPath))
            {
                return View(viewPath);
            }
            else
            {
                return View("Index");
            }
        }

       public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool ViewExists(string name)
        {
            ViewEngineResult viewResult = _razorViewEngine.FindView(ControllerContext, name, true);
            return (viewResult != null);
        }
    }
}
