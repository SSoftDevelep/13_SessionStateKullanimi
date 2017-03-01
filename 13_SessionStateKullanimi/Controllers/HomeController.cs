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
            //Session["deger"] = "Fernando Muslera,29";  //ayni session a 2.kez atamayla ezilir.
            //Session.Add("deger", text);

            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            if (Session["deger"] != null)
            {
                ViewBag.Deger = Session["deger"].ToString();
            }

            else
                ViewBag.Deger = "Session verisi yoktur !";

            return View();
        }

        public ActionResult Index3()
        {
            Session.Clear(); //tüm session verisini temizler.

            if (Session["deger"]!=null)
            {
                Session.Remove("deger");  //deger anahtarini siler.
            }
            return RedirectToAction("Index2");
        }
    }
}