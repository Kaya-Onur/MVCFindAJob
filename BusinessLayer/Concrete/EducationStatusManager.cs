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
    public class EducationStatusManager : IEducationStatusService
    {
        IEducationStatusDal _educationStatusDal;

        public EducationStatusManager(IEducationStatusDal educationStatusDal)
        {
            _educationStatusDal = educationStatusDal;
        }
        public void Add(EducationStatus p)
        {
            _educationStatusDal.Insert(p);
        }

        public void Delete(EducationStatus p)
        {
            p.Status = false;
            _educationStatusDal.Update(p);
        }

        public EducationStatus GetByID(int id)
        {
            return _educationStatusDal.Get(x => x.EducationStatusID == id);
        }

        public List<EducationStatus> GetList()
        {
            return _educationStatusDal.List();
        }

        public void Update(EducationStatus p)
        {
            _educationStatusDal.Update(p);
        }
    }
}
