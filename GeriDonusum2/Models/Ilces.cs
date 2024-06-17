using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Ilces
    {
        [Key]
        public int ilce_id { get; set; }
        public string ilce_adi { get; set; }
        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }
}
