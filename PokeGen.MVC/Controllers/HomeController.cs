using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokeGen.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var doc = new HtmlDocument();
            doc.Load(HttpContext.Request.PhysicalApplicationPath + @"Content\Textfiles\AnimalTable.html");
            var value = doc.DocumentNode.SelectNodes("//tr/td");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}