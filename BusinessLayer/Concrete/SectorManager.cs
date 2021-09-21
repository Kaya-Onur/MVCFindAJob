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
    public class SectorManager : ISectorService
    {
        ISectorDal _sectorDal;

        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }
        public void Add(Sector p)
        {
            _sectorDal.Insert(p);
        }

        public void Delete(Sector p)
        {
            p.Status = false;
            _sectorDal.Update(p);
        }

        public Sector GetByID(int id)
        {
            return _sectorDal.Get(x => x.SectorID == id);
        }

        public List<Sector> GetList()
        {
            return _sectorDal.List();
        }

        public void Update(Sector p)
        {
            _sectorDal.Update(p);
        }
    }
}
