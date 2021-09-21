using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserJobAdvertisement
    {
        
        public int JobAdvertisementID { get; set; }
        public int UserID { get; set; }
        public bool Status { get; set; }




        public User User { get; set; }
        public JobAdvertisement JobAdvertisement { get; set; }
    }
}
