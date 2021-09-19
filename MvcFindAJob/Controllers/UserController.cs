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

        public ActionResult GetUserList()
        {
            var uservalues = um.GetList();
            return View(uservalues);
        }
        [HttpGet]
        public ActionResult AddUser()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User p)
        {
            um.UserAdd(p);
            return RedirectToAction("GetUserList");
        }
    }
}