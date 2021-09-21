using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserJobAdvertisementService:IService<UserJobAdvertisement>
    {
        List<UserJobAdvertisement> GetListByUser(int id);
        UserJobAdvertisement GetByIDs(int id1,int id2);
    }
}
