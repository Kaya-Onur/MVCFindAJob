using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(1000)]
        public string UserImage { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Password { get; set; }


        public ICollection<UserJobAdvertisement> UserJobAdvertisements { get; set; }


        public int EducationStatusID { get; set; }
        public virtual EducationStatus EducationStatus { get; set; }

        public int ForeignLanguageID { get; set; }
        public virtual ForeignLanguage ForeignLanguage { get; set; }

        public int ProfessionID { get; set; }
        public virtual Profession Profession { get; set; }

        public int CityID { get; set; }
        public virtual City City { get; set; }

        
    }
}
