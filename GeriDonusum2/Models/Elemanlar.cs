using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Elemanlar
    {
        [Key]
        public int eleman_id { get; set; }
        public string eleman_adi { get; set; }
        public int pozisyon_id { get; set; }
        public int sirket_id { get; set; }
        public string eleman_telefon { get; set; }
        public string sifre { get; set; }

        public virtual Sirketler Sirketler { get; set; }
        public virtual Pozisyonlar Pozisyon { get; set; }
    }
}
