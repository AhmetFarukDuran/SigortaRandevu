using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandevuSistemi.Models;

namespace RandevuSistemi.Controllers
{
    public class KisilerController : Controller
    {
        Context c = new Context();
        // GET: Kisiler
        public ActionResult Index()
        {
            var deger = c.Kisilers.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult KisiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KisiEkle(Kisiler p)
        {
            
            if (ModelState.IsValid)
            {
                c.Kisilers.Add(p);
                c.SaveChanges();
                return View();
                //Eğer Tüm Parametreler doğruysa buraya gir.
            }
            

            return RedirectToAction("Index");

        }
    }
}