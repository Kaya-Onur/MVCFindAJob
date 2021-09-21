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
    public class JobTypeManager : IJobTypeService
    {
        IJobTypeDal _jobTypeDal;

        public JobTypeManager(IJobTypeDal jobTypeDal)
        {
            _jobTypeDal = jobTypeDal;
        }
        public void Add(JobType p)
        {
            _jobTypeDal.Insert(p);
        }

        public void Delete(JobType p)
        {
            p.Status = false;
            _jobTypeDal.Update(p);
        }

        public JobType GetByID(int id)
        {
            return _jobTypeDal.Get(x => x.JobTypeID == id);
        }

        public List<JobType> GetList()
        {
            return _jobTypeDal.List();
        }

        public void Update(JobType p)
        {
            _jobTypeDal.Update(p);
        }
    }
}
