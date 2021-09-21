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
    public class SectorController : Controller
    {
        SectorManager sm = new SectorManager(new EfSectorDal());
        [Authorize(Roles = "A")]
        public ActionResult GetListSector()
        {
            var sectorValues = sm.GetList();
            return View(sectorValues);
        }
        [HttpGet]
        public ActionResult AddSector()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSector(Sector p)
        {
            sm.Add(p);
            return RedirectToAction("GetListSector");
        }
        [HttpGet]
        public ActionResult UpdateSector(int id)
        {
            var sectorValue = sm.GetByID(id);
            return View(sectorValue);
        }
        [HttpPost]
        public ActionResult UpdateSector(Sector p)
        {
            sm.Update(p);
            return RedirectToAction("GetListSector");

        }
        public ActionResult DeleteSector(int id)
        {
            var sectorValue = sm.GetByID(id);
            sm.Delete(sectorValue);
            return RedirectToAction("GetListSector");
        }
    }
}