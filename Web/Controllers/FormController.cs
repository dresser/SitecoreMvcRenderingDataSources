using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Form()
        {
            var model = new FormModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult FormSubmit(FormModel data)
        {
            var model = new FormModel();
            return View("Form", model);
        }
    }
}