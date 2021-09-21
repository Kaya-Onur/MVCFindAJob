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
    public class UserJobAdvertisementManager : IUserJobAdvertisementService
    {
        IUserJobAdvertisementDal _userJobAdvertisementDal;

        public UserJobAdvertisementManager(IUserJobAdvertisementDal userJobAdvertisementDal)
        {
            _userJobAdvertisementDal = userJobAdvertisementDal;
        }
        public void Add(UserJobAdvertisement p)
        {

            _userJobAdvertisementDal.Insert(p);
        }

        public void Delete(UserJobAdvertisement p)
        {
           
            _userJobAdvertisementDal.Update(p);
        }

        public UserJobAdvertisement GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public UserJobAdvertisement GetByIDs(int id1,int id2)
        {
            return _userJobAdvertisementDal.Get(x => x.JobAdvertisementID == id1 && x.UserID==id2);
        }

        public List<UserJobAdvertisement> GetList()
        {
            return _userJobAdvertisementDal.List();
        }

        public List<UserJobAdvertisement> GetListByUser(int id)
        {
            return _userJobAdvertisementDal.List(x => x.UserID == id);
        }

        public void Update(UserJobAdvertisement p)
        {
            _userJobAdvertisementDal.Update(p);
        }
    }
}
