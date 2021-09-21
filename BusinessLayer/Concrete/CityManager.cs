using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void Add(City city)
        {
            _cityDal.Insert(city);
        }

        public void Delete(City city)
        {
            city.Status = false;
            _cityDal.Update(city);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }

        public City GetByID(int id)
        {
            return _cityDal.Get(x => x.CityID == id);
        }

        public List<City> GetList()
        {
            return _cityDal.List();
        }
    }
}
