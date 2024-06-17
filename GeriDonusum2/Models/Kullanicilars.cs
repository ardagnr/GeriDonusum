using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Kullanicilars
    {
        [Key]
        public int kullanici_id { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string olusturma_tarihi { get; set; }
        public string telefon_numarasi { get; set; }

        public virtual ICollection<Kullanicilar_urunler> KullaniciUrunler { get; set; }
    }
}
