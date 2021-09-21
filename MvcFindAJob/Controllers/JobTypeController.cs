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
    public class JobTypeController : Controller
    {
        JobTypeManager jtm = new JobTypeManager(new EfJobTypeDal());
        [Authorize(Roles = "A")]
        public ActionResult GetListJobType()
        {
            var jobTypeValues = jtm.GetList();
            return View(jobTypeValues);
        }
        [HttpGet]
        public ActionResult AddJobType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJobType(JobType p)
        {
            jtm.Add(p);
            return RedirectToAction("GetListJobType");
        }
        [HttpGet]
        public ActionResult UpdateJobType(int id)
        {
            var jobTypeValue = jtm.GetByID(id);
            return View(jobTypeValue);
        }
        [HttpPost]
        public ActionResult UpdateJobType(JobType p)
        {
            jtm.Update(p);
            return RedirectToAction("GetListJobType");

        }
        public ActionResult DeleteJobType(int id)
        {
            var jobTypeStatusValue = jtm.GetByID(id);
            jtm.Delete(jobTypeStatusValue);
            return RedirectToAction("GetListJobType");
        }
    }
}