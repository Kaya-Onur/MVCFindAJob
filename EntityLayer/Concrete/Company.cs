using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [StringLength(100)]
        public string CompanyName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(1000)]
        public string Logo { get; set; }
        [StringLength(1000)]
        public string CompanyWebsite { get; set; }


        public int CityID { get; set; }
        public virtual City City { get; set; }

        public int SectorID { get; set; }
        public virtual Sector Sector { get; set; }

        public ICollection<JobAdvertisement> jobAdvertisements { get; set; }


    }
}
