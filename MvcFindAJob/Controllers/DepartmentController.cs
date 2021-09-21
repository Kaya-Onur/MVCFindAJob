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
    public class DepartmentController : Controller
    {
        DepartmentManager dm = new DepartmentManager(new EfDepartmentDal());
        // GET: Department
        [Authorize(Roles = "A")]
        public ActionResult GetListDepartment()
        {
            var departmentValues = dm.GetList();
            return View(departmentValues);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department p)
        {
            dm.Add(p);
            return RedirectToAction("GetListDepartment");
        }
        [HttpGet]
        public ActionResult UpdateDepartment(int id)
        {
            var departmentValue = dm.GetByID(id);
            return View(departmentValue);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department p)
        {
            dm.Update(p);
            return RedirectToAction("GetListDepartment");

        }
        public ActionResult DeleteDepartment(int id)
        {
            var departmentValue = dm.GetByID(id);
            dm.Delete(departmentValue);
            return RedirectToAction("GetListDepartment");
        }
    }
}