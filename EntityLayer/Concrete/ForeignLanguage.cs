using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ForeignLanguage
    {
        [Key]
        public int ForeignLanguageID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public bool Status { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<JobAdvertisement> jobAdvertisements { get; set; }
    }
}
