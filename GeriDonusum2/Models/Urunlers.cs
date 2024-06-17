using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Urunlers
    {
        [Key]
        public int urun_id { get; set; }
        public string urun_turu { get; set; }
        public int satis_fiyat { get; set; }
        public int geridonusum_fiyati { get; set; }
        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }
}
