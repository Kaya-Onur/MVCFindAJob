using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFindAJob.Controllers
{
    public class ForeignLanguageController : Controller
    {
        ForeignLanguageManager flm = new ForeignLanguageManager(new EfForeignLanguageDal());
        [Authorize(Roles = "A")]
        public ActionResult GetListForeignLanguage()
        {
            var foreignLanguageValues = flm.GetList();
            return View(foreignLanguageValues);
        }
        [HttpGet]
        public ActionResult AddForeignLanguage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddForeignLanguage(ForeignLanguage p)
        {
            flm.Add(p);
            return RedirectToAction("GetListForeignLanguage");
        }
        [HttpGet]
        public ActionResult UpdateForeignLanguage(int id)
        {
            var foreignLanguageValue = flm.GetByID(id);
            return View(foreignLanguageValue);
        }
        [HttpPost]
        public ActionResult UpdateForeignLanguage(ForeignLanguage p)
        {
            flm.Update(p);
            return RedirectToAction("GetListForeignLanguage");

        }
        public ActionResult DeleteForeignLanguage(int id)
        {
            var foreignLanguageValue = flm.GetByID(id);
            flm.Delete(foreignLanguageValue);
            return RedirectToAction("GetListForeignLanguage");
        }
    }
}