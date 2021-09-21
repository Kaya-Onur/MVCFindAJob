using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcFindAJob.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

      
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context context = new Context();
            var adminValue = context.Admins.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (adminValue!=null)
            {
                FormsAuthentication.SetAuthCookie(adminValue.Email,false);
                Session["Email"] = adminValue.Email;
                return RedirectToAction("GetListJobAdvertisement", "JobAdvertisement");
            }
            else
            {
                return RedirectToAction("AdminLogin");
            }
           
        
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User p)
        {
            Context context = new Context();
            var userValue = context.Users.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (userValue != null)
            {
                FormsAuthentication.SetAuthCookie(userValue.Email, false);
                Session["Email"] = userValue.Email;
                return RedirectToAction("GetListJobAdvertisement", "UserPanel");
            }
            else
            {
                return RedirectToAction("UserLogin");
            }


        }
    }
}