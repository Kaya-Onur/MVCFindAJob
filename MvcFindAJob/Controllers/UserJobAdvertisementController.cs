using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFindAJob.Controllers
{
    public class UserJobAdvertisementController : Controller
    {
        UserJobAdvertisementManager ujam = new UserJobAdvertisementManager(new EfUserJobAdvertisementDal());
        public ActionResult AddUserJobAdvertisement()
        {
            return View();
        }
        public ActionResult DeleteUserJobAdvertisement()
        {
            return View();
        }
    }
}