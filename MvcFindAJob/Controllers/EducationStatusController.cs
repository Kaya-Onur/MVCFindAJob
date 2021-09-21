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
    public class EducationStatusController : Controller
    {
        EducationStatusManager esm = new EducationStatusManager(new EfEducationStatusDal());
        [Authorize(Roles = "A")]
        public ActionResult GetListEducationStatus()
        {
            var educationStatusValues = esm.GetList();
            return View(educationStatusValues);
        }
        [HttpGet]
        public ActionResult AddEducationStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducationStatus(EducationStatus p)
        {
            esm.Add(p);
            return RedirectToAction("GetListEducationStatus");
        }
        [HttpGet]
        public ActionResult UpdateEducationStatus(int id)
        {
            var educationStatusValue = esm.GetByID(id);
            return View(educationStatusValue);
        }
        [HttpPost]
        public ActionResult UpdateEducationStatus(EducationStatus p)
        {
            esm.Update(p);
            return RedirectToAction("GetListEducationStatus");

        }
        public ActionResult DeleteEducationStatus(int id)
        {
            var educationStatusValue = esm.GetByID(id);
            esm.Delete(educationStatusValue);
            return RedirectToAction("GetListEducationStatus");
        }
    }
}