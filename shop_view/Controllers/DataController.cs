using System;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;
using shop_view.Models;

namespace RegistrationForm.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            var model = new RegistrationModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }

            return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
