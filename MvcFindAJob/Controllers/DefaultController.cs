using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFindAJob.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        JobAdvertisementManager jam = new JobAdvertisementManager(new EfJobAdvertisementDal());

        public ActionResult Index()
        {
            var jobAdvertisementValues = jam.GetList();
            return View(jobAdvertisementValues);
           
        }
        
 
        public ActionResult JobAdvertisementList()
        {
            var jobAdvertisement = jam.GetList();
            return View(jobAdvertisement);
        }
        public ActionResult GetJobAdvertisement(int id=1)
        {
            var jobadValue = jam.GetByID(id);
            return View(jobadValue);
        }
    }
}