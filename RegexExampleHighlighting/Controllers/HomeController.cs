using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace RegexExampleHighlighting.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //the term you want to search for, and the color you want to highlight.
            ViewData["searchterm"] = "aster";
            ViewData["highlightcolor"] = "yellow";

            // Get a string and send it over to the view, which will call the helper method in the RegexHelp.cs file.
            ViewData["temp"] = "aster faster plaster mastering forecaster.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}