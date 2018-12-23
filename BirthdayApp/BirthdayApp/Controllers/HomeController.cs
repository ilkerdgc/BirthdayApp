using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel davetiyeModel)
        {
            if (ModelState.IsValid)
            {
                Veritabanı.Add(davetiyeModel);
                return View("Thanks", davetiyeModel);
               
            }

            return View(davetiyeModel);
        }

        [ChildActionOnly]
        public ActionResult _Katilanlar()
        {
            return PartialView(Veritabanı.Liste.Where(x => x.KatilmaDurumu == true));
        }
    }
}