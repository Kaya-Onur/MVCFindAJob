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
    public class ProfessionController : Controller
    {
        ProfessionManager pm = new ProfessionManager(new EfProfessionDal());
        [Authorize(Roles = "A")]
        public ActionResult GetListProfession()
        {
            var professionValues = pm.GetList();
            return View(professionValues);
        }
        [HttpGet]
        public ActionResult AddProfession()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfession(Profession p)
        {
            pm.Add(p);
            return RedirectToAction("GetListProfession");
        }
        [HttpGet]
        public ActionResult UpdateProfession(int id)
        {
            var professionValue = pm.GetByID(id);
            return View(professionValue);
        }
        [HttpPost]
        public ActionResult UpdateProfession(Profession p)
        {
            pm.Update(p);
            return RedirectToAction("GetListProfession");

        }
        public ActionResult DeleteProfession(int id)
        {
            var professionValue = pm.GetByID(id);
            pm.Delete(professionValue);
            return RedirectToAction("GetListProfession");
        }
    }
}