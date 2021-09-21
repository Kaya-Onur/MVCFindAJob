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
    public class CityController : Controller
    {
        CityManager cm = new CityManager(new EfCityDal());
        [Authorize(Roles ="A")]
        public ActionResult GetListCity()
        {
            var cityValues = cm.GetList();
            return View(cityValues);
        }
        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(City p)
        {
            cm.Add(p);
            return RedirectToAction("GetListCity");
        }
        [HttpGet]
        public ActionResult UpdateCity(int id)
        {
            var cityValue = cm.GetByID(id);
            return View(cityValue);
        }
        [HttpPost]
        public ActionResult UpdateCity(City p)
        {
            cm.Update(p);
            return RedirectToAction("GetListCity");

        }
        public ActionResult DeleteCity(int id)
        {
            var cityValue = cm.GetByID(id);
            cm.Delete(cityValue);
            return RedirectToAction("GetListCity");
        }
    }
}