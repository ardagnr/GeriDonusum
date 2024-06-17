using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Kullanicilar_urunler
    {
        [Key]
        [Column(Order = 1)]
        public int kullanici_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int urun_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public int sehir_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public int ilce_id { get; set; }

        public int miktar { get; set; }

        public virtual Kullanicilars Kullanicilar { get; set; }
        public virtual Urunlers Urunler { get; set; }
        public virtual Sehirlers Sehirler { get; set; }
        public virtual Ilces Ilce { get; set; }
    }
}
