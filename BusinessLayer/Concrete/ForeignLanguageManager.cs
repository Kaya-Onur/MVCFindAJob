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
    public class ForeignLanguageManager : IForeignLanguageService
    {
        IForeignLanguageDal _foreignLanguageDal;

        public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal)
        {
            _foreignLanguageDal = foreignLanguageDal;
        }
        public void Add(ForeignLanguage p)
        {
            _foreignLanguageDal.Insert(p);
        }

        public void Delete(ForeignLanguage p)
        {
            p.Status = false;
            _foreignLanguageDal.Update(p);
        }

        public ForeignLanguage GetByID(int id)
        {
            return _foreignLanguageDal.Get(x=>x.ForeignLanguageID==id);
        }

        public List<ForeignLanguage> GetList()
        {
            return _foreignLanguageDal.List();
        }

        public void Update(ForeignLanguage p)
        {
            _foreignLanguageDal.Update(p);
        }
    }
}
