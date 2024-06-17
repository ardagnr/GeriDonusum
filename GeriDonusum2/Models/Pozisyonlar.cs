using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Pozisyonlar
    {
        [Key]
        public int pozisyon_id{ get; set; }
        public string pozisyon_adi { get; set; }

        public virtual ICollection<Elemanlar> Elemanlar { get; set; }
    }
}
