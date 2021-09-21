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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public void Add(Company company)
        {
            _companyDal.Insert(company);
        }

        public void Delete(Company company)
        {
            company.Status = false;
            _companyDal.Update(company);
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }

        public Company GetByID(int id)
        {
            return _companyDal.Get(x => x.CompanyID == id);
        }

        public List<Company> GetList()
        {
            return _companyDal.List();

        }
    }
}
