using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Novacode;

namespace DocumentGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var document = DocX.Load(@"C:\Users\Si\Documents\GitHub\AnimalRecueDocumentGenereator\docs\2014 New Adoption form.doc");

            document.ReplaceText("%POSTCODE%", "M219SP");

            document.SaveAs("NewFile.docx");

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