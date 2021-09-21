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
    public class ProfessionManager : IProfessionService
    {
        IProfessionDal _professionDal;

        public ProfessionManager(IProfessionDal professionDal)
        {
            _professionDal = professionDal;
        }
        public void Add(Profession p)
        {
            _professionDal.Insert(p);
        }

        public void Delete(Profession p)
        {
            p.Status = false;
            _professionDal.Update(p);
        }

        public Profession GetByID(int id)
        {
            return _professionDal.Get(x => x.ProfessionID == id);
        }

        public List<Profession> GetList()
        {
            return _professionDal.List();
        }

        public void Update(Profession p)
        {
            _professionDal.Update(p);
        }
    }
}
