using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public void Add(Department p)
        {
            _departmentDal.Insert(p);
        }

        public void Delete(Department p)
        {
            p.Status = false;
            _departmentDal.Update(p);
        }

        public Department GetByID(int id)
        {
            return _departmentDal.Get(x => x.DepartmentID == id);
        }

        public List<Department> GetList()
        {
            return _departmentDal.List();
        }

        public void Update(Department p)
        {
            _departmentDal.Update(p);
        }
    }
}
