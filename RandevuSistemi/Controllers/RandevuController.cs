using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandevuSistemi.Models;
namespace RandevuSistemi.Controllers
{
    public class RandevuController : Controller
    {
        Context c = new Context();
        // GET: Randevu
        public ActionResult Index()
        {
            var deger = c.Randevus.Where(x => x.Onay == false).ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult RandevuAl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RandevuAl(Randevu p)
        {
            c.Randevus.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RandevuGetir(int id)
        {
            var rd = c.Randevus.Find(id);
            return View("RandevuGetir", rd);
        }
        public ActionResult RandevuGüncelle(Randevu r)
        {
            var ran = c.Randevus.Find(r.Randevuid);
            ran.Tarih = r.Tarih;
            ran.Onay = true;
            c.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}