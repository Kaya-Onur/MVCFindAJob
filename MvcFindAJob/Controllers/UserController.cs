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
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        CityManager cm = new CityManager(new EfCityDal());
        ProfessionManager pm = new ProfessionManager(new EfProfessionDal());
        EducationStatusManager esm = new EducationStatusManager(new EfEducationStatusDal());
        ForeignLanguageManager flm = new ForeignLanguageManager(new EfForeignLanguageDal());
        [Authorize]

        public ActionResult GetUserList()
        {
            var uservalues = um.GetList();
            return View(uservalues);
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            List<SelectListItem> cityValue = (from x in cm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.CityID.ToString()
                                                 }).ToList();
            List<SelectListItem> professionValue = (from x in pm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.ProfessionID.ToString()
                                                 }).ToList();
            List<SelectListItem> foreignValue = (from x in flm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ForeignLanguageID.ToString()
                                                    }).ToList();
            List<SelectListItem> educationValue = (from x in esm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.EducationStatusID.ToString()
                                                   }).ToList();
           
            ViewBag.cityVl = cityValue;
            ViewBag.professionVl = professionValue;
            ViewBag.foreignVl = foreignValue;
            ViewBag.educationVl = educationValue;
          
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User p)
        {
            um.Add(p);
            return RedirectToAction("GetUserList");
        }
        [HttpGet]
        public ActionResult UpdateUser(int id)
        {
            List<SelectListItem> cityValue = (from x in cm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.CityID.ToString()
                                              }).ToList();
            List<SelectListItem> professionValue = (from x in pm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ProfessionID.ToString()
                                                    }).ToList();
            List<SelectListItem> foreignValue = (from x in flm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.ForeignLanguageID.ToString()
                                                 }).ToList();
            List<SelectListItem> educationValue = (from x in esm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.EducationStatusID.ToString()
                                                   }).ToList();

            ViewBag.cityVl = cityValue;
            ViewBag.professionVl = professionValue;
            ViewBag.foreignVl = foreignValue;
            ViewBag.educationVl = educationValue;
            var userValue = um.GetByID(id);
            return View(userValue);
        }
        [HttpPost]
        public ActionResult UpdateUser(User p)
        {
            um.Update(p);
            return RedirectToAction("GetUserList");

        }
        public ActionResult DeleteUser(int id)
        {
            var userValue = um.GetByID(id);
            um.Delete(userValue);
            return RedirectToAction("GetUserList");
        }
    }
}