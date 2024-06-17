using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriDonusum2.Models
{
    public class Sirketler
    {
        [Key]
        public int sirket_id { get; set; }
        public string sirket_adi { get; set; }
        public string adres { get; set; }

        public virtual ICollection<Elemanlar> Elemanlar { get; set; }
    }
}
