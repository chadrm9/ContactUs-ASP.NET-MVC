using System;
using System.Web.Mvc;
using ExampleSite.Models;

namespace ExampleSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HowItWorks()
        {
            return View();
        }

        public ActionResult InTheNews()
        {
            return View();
        }

        public ActionResult OurLocations()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        [AcceptVerbs("GET")]
        public ActionResult ContactUs()
        {
            return View();
        }

        [AcceptVerbs("POST")]
        public ActionResult ContactUs(ContactUsModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                // Do model valid
                return RedirectToAction("ContactUs");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);

                return View(model);
            }
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult PrivacyStatement()
        {
            return View();
        }

        public ActionResult TermsOfService()
        {
            return View();
        }
    }
}