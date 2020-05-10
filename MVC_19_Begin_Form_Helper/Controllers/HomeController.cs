using MVC_19_Begin_Form_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_19_Begin_Form_Helper.Controllers
{
    public class HomeController : Controller
    {
        NORTHWND db = new NORTHWND();
        public ActionResult Index()
        {
            ViewBag.Calisanlar = db.Employees;
        /*  Calisan c = new Calisan()
            {
                ad = "Negan",
                unvan = (Title)15
            }; */
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                TempData["mesaj"] = new string[] { "alert alert-success", "Kaydedildi." };
            }
            catch (Exception)
            {
                TempData["mesaj"] = new string[] { "alert alert-danger", "Kaydedilemedi." };
            }
            return RedirectToAction("Index");
        }
    }
}