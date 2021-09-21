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
    public class JobAdvertisementManager : IJobAdvertisementService
    {
        IJobAdvertisementDal _jobAdvertisementDal;

        public JobAdvertisementManager(IJobAdvertisementDal jobAdvertisementDal)
        {
            _jobAdvertisementDal = jobAdvertisementDal;
        }
        public void Add(JobAdvertisement p)
        {
            _jobAdvertisementDal.Insert(p);
        }

        public void Delete(JobAdvertisement p)
        {
            p.jobAdvertisementStatus = false;
            _jobAdvertisementDal.Update(p);
        }

        public JobAdvertisement GetByID(int id)
        {
            return _jobAdvertisementDal.Get(x => x.JobAdvertisementID == id);
        }

        public List<JobAdvertisement> GetList()
        {
            return _jobAdvertisementDal.List();
        }

        public void Update(JobAdvertisement p)
        {
            _jobAdvertisementDal.Update(p);
        }
    }
}
