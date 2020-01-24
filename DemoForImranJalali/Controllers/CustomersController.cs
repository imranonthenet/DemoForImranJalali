using DemoForImranJalali.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForImranJalali.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                ResponseVM response = new ResponseVM { RedirectURL = "/customers/success" };
                return Json(new { response });
            }

            List<ModelError> errors = Util.GetModelErrors(ModelState);
            return Json(new { errors });
        }

        public ActionResult Success()
        {
            return View();
        }

    }
}