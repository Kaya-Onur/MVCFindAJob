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
    public class JobAdvertisementController : Controller
    {
        JobAdvertisementManager jam = new JobAdvertisementManager(new EfJobAdvertisementDal());
        CompanyManager com = new CompanyManager(new EfCompanyDal());
        JobTypeManager jtm = new JobTypeManager(new EfJobTypeDal());
        DepartmentManager dm = new DepartmentManager(new EfDepartmentDal());
        EducationStatusManager esm = new EducationStatusManager(new EfEducationStatusDal());
        ForeignLanguageManager flm = new ForeignLanguageManager(new EfForeignLanguageDal());
     
        public ActionResult GetListJobAdvertisement()
        {
            var jobAdvertisementValues = jam.GetList();
            return View(jobAdvertisementValues);
        }
        [HttpGet]
        public ActionResult AddJobAdvertisement()
        {
            List<SelectListItem> companyValue = (from x in com.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CompanyName,
                                                  Value = x.CompanyID.ToString()
                                              }).ToList();
            List<SelectListItem> jobTypeValue = (from x in jtm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.JobTypeID.ToString()
                                                }).ToList();
            List<SelectListItem> departmentValue = (from x in dm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.DepartmentID.ToString()
                                                 }).ToList();
            List<SelectListItem> educationValue = (from x in esm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.EducationStatusID.ToString()
                                                 }).ToList();
            List<SelectListItem> foreignValue = (from x in flm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.ForeignLanguageID.ToString()
                                                 }).ToList();
            ViewBag.companyVl = companyValue;
            ViewBag.jobTypeVl = jobTypeValue;
            ViewBag.departmentVl = departmentValue;
            ViewBag.educationVl = educationValue;
            ViewBag.foreignVl = foreignValue;
       
            return View();
        }
        [HttpPost]
        public ActionResult AddJobAdvertisement(JobAdvertisement p)
        {
            jam.Add(p);
            return RedirectToAction("GetListJobAdvertisement");
        }
        [HttpGet]
        public ActionResult UpdateJobAdvertisement(int id)
        {
            List<SelectListItem> companyValue = (from x in com.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CompanyName,
                                                     Value = x.CompanyID.ToString()
                                                 }).ToList();
            List<SelectListItem> jobTypeValue = (from x in jtm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.JobTypeID.ToString()
                                                 }).ToList();
            List<SelectListItem> departmentValue = (from x in dm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.DepartmentID.ToString()
                                                    }).ToList();
            List<SelectListItem> educationValue = (from x in esm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.EducationStatusID.ToString()
                                                   }).ToList();
            List<SelectListItem> foreignValue = (from x in flm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.ForeignLanguageID.ToString()
                                                 }).ToList();
            ViewBag.companyVl = companyValue;
            ViewBag.jobTypeVl = jobTypeValue;
            ViewBag.departmentVl = departmentValue;
            ViewBag.educationVl = educationValue;
            ViewBag.foreignVl = foreignValue;
            var jobAdvertisementValue = jam.GetByID(id);
            return View(jobAdvertisementValue);
        }
        [HttpPost]
        public ActionResult UpdateJobAdvertisement(JobAdvertisement p)
        {
            jam.Update(p);
            return RedirectToAction("GetListJobAdvertisement");

        }
        public ActionResult DeleteJobAdvertisement(int id)
        {
            var jobAdvertisementValue = jam.GetByID(id);
            jam.Delete(jobAdvertisementValue);
            return RedirectToAction("GetListJobAdvertisement");
        }

        

        
    }
}