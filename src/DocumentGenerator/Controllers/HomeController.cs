using System;
using System.Web.Mvc;
using DocumentGenerator.Models;

namespace DocumentGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }

    public class DocumentController : Controller
    {
        [HttpGet]
        public ActionResult AdoptionForm()
        {
            var model = new AdoptionFormModel
            {
                Date = DateTime.Now.Date
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AdoptionForm(AdoptionFormModel adoptionFormModel)
        {
            var document = Novacode.DocX.Load(@"C:\Users\Bob\Documents\Coding\DocumentGenereator\docs\2014 New Adoption form.docx");

            document.ReplaceText("%DATE%", adoptionFormModel.Date.ToShortDateString());
            document.ReplaceText("%NAME%", BuildAddress(adoptionFormModel.AddressLine1, adoptionFormModel.AddressLine2, adoptionFormModel.AddressLine3));
            document.ReplaceText("%ADDRESS%", adoptionFormModel.Date.ToShortDateString());
            document.ReplaceText("%POSTCODE%", adoptionFormModel.Postcode);
            document.ReplaceText("%PHONENUMBER%", adoptionFormModel.TelephoneNumber);
            document.ReplaceText("%EMAILADDRESS%", adoptionFormModel.EmailAddress);
            document.ReplaceText("%ANIMALNAME%", adoptionFormModel.AnimalName);

            document.SaveAs(String.Format(@"C:\Users\Bob\Documents\Coding\DocumentGenereator\docs\{0}.docx", adoptionFormModel.FullName));





            return View();
        }

        private string BuildAddress(string addressLine1, string addressLine2, string addressLine3)
        {
            var address = addressLine1;

            if (!string.IsNullOrWhiteSpace(addressLine2))
            {
                address += Environment.NewLine + addressLine2;
        }

            if (!string.IsNullOrWhiteSpace(addressLine3))
        {
                address += Environment.NewLine + addressLine3;
            }

            return address;
        }
    }
}