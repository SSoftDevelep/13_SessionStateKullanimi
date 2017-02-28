using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_SessionStateKullanimi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text) //kullanicidan aldigim bilgi
        {
            Session["deger"] = text;  //session obje tutar.
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Deger = Session["deger"].ToString();
            return View();
        }
    }
}