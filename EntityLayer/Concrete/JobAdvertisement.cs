using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class JobAdvertisement
    {
        [Key]
        public int JobAdvertisementID { get; set; }
        
        public DateTime AdversimentDate { get; set; }
        
        public bool jobAdvertisementStatus { get; set; }
        [StringLength(5000)]
        public string GeneralQualifications { get; set; }
        [StringLength(5000)]
        public string JobDescription { get; set; }
        
        public int Experience { get; set; }
        public bool MilitaryStatus { get; set; }


        public ICollection<UserJobAdvertisement> UserJobAdvertisements { get; set; }


        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }


        public int JobTypeID { get; set; }
        public virtual JobType JobType { get; set; }

        

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public int EducationStatusID { get; set; }
        public virtual EducationStatus EducationStatus { get; set; }


        public int ForeignLanguageID { get; set; }
        public virtual ForeignLanguage ForeignLanguage { get; set; }

        
    }
}
