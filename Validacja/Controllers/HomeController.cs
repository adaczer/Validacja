using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacja.Models;

namespace Validacja.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pracownik pracownik)
        {
            if (ModelState.IsValid)
            {
                return View("Index2", pracownik);
            }
            else
            {
                return View("Index");
            }

        }


    }
}