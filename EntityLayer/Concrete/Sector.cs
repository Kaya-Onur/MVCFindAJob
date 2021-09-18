using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sector
    {
        [Key]
        public int SectorID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
