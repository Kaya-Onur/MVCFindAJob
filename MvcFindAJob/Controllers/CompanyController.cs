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
    public class CompanyController : Controller
    {
        CompanyManager cm = new CompanyManager(new EfCompanyDal());
        CityManager cim = new CityManager(new EfCityDal());
        SectorManager sm = new SectorManager(new EfSectorDal());
        [Authorize]
        public ActionResult GetListCompany()
        {
            var companyValues = cm.GetList();
            return View(companyValues);
        }
        [HttpGet]
        public ActionResult AddCompany()
        {
            List<SelectListItem> cityValue = (from x in cim.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.CityID.ToString()
                                                 }).ToList();
            List<SelectListItem> sectorValue = (from x in sm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.SectorID.ToString()
                                                 }).ToList();
            ViewBag.cityVl = cityValue;
            ViewBag.sectorVl = sectorValue;
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company p)
        {
            cm.Add(p);
            return RedirectToAction("GetListCompany");
        }
        [HttpGet]
        public ActionResult UpdateCompany(int id)
        {
            List<SelectListItem> cityValue = (from x in cim.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.CityID.ToString()
                                              }).ToList();
            List<SelectListItem> sectorValue = (from x in sm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.SectorID.ToString()
                                                }).ToList();
            ViewBag.cityVl = cityValue;
            ViewBag.sectorVl = sectorValue;
            var companyValue = cm.GetByID(id);
            return View(companyValue);
        }
        [HttpPost]
        public ActionResult UpdateCompany(Company p)
        {
            cm.Update(p);
            return RedirectToAction("GetListCompany");

        }
        public ActionResult DeleteCompany(int id)
        {
            var companyValue = cm.GetByID(id);
            cm.Delete(companyValue);
            return RedirectToAction("GetListCompany");
        }
    }
}