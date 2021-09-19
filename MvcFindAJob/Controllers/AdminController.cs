using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcFindAJob.Controllers
{
    public class AdminController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminDal());
        AdminValidatior av = new AdminValidatior();
        public ActionResult GetAdminList()
        {
            var adminValues = adm.GetList();
            return View(adminValues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            ValidationResult results = av.Validate(p);
            if (results.IsValid) 
            { 
                adm.AdminAdd(p);
                return RedirectToAction("GetAdminList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}