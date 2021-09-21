using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFindAJob.Controllers
{
    public class UserPanelController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        UserJobAdvertisementManager ujam = new UserJobAdvertisementManager(new EfUserJobAdvertisementDal());
        JobAdvertisementManager jam = new JobAdvertisementManager(new EfJobAdvertisementDal());

      
        public ActionResult UserProfile()
        {
            
            return View();
        }
        public ActionResult GetListJobAdvertisement()
        {
            var jobAdvertisementValues = jam.GetList();
            return View(jobAdvertisementValues);
        }
        public ActionResult MyApplications(string p)
        {
            Context context = new Context();
            p = (string)Session["Email"];
            var userIdInfo = context.Users.Where(x => x.Email == p).FirstOrDefault();
            int id = userIdInfo.UserID;
            var values = ujam.GetListByUser(id);
            List<JobAdvertisement> jobAdvertisements = new List<JobAdvertisement>();
           
            foreach (var item in values)
            {              
                jobAdvertisements.Add(jam.GetByID(item.JobAdvertisementID));
            }
            ViewBag.values = ujam.GetList();
            return View(jobAdvertisements);
        }
        public ActionResult DeleteJobAdvertisement(int id, string p)
        {

            Context context = new Context();
            p = (string)Session["Email"];
            var userIdInfo = context.Users.Where(x => x.Email == p).FirstOrDefault();
            int userId = userIdInfo.UserID;
            var value=ujam.GetByIDs(id,userId);
            value.Status = false;
            ujam.Delete(value);
            return RedirectToAction("MyApplications");
            

        }

    }
}