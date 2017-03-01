using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_SessionStateKullanimi.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            HttpContext.Application["sayac"] = 1;
            //HttpContext.Application.Add("sayac", 1);

            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Sayac = HttpContext.Application["sayac"].ToString();
            return View();
        }

        public ActionResult Index3()
        {
            if (HttpContext.Application["sayac"] != null)
            {
                int sayac = (int)HttpContext.Application["sayac"];
                sayac++;
                HttpContext.Application["sayac"] = sayac;
                return RedirectToAction("Index2");
            }
            else
                return RedirectToAction("Index");
            
            
        }

        public ActionResult Index4()
        {
            /*HttpContext.Application.Clear();  //hepsini temizleme
              HttpContext.Application.RemoveAll(); //hepsini temizleme */

            if (HttpContext.Application["sayac"] != null)
            {
                HttpContext.Application.Remove("sayac");
                
            }
            return RedirectToAction("Index");

        }
    }
}