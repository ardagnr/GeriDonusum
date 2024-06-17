using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeriDonusum2.Models;

namespace GeriDonusum2
{
    public partial class FrmAtıkBilgileri : Form
    {
        private GeriDonusumContext _context;
        public FrmAtıkBilgileri()
        {
            InitializeComponent();
            _context = new GeriDonusumContext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRaporlar fr = new FrmRaporlar();
            fr.kullanicid = kullaniciid;
            fr.Show();
            this.Hide();
        }

        public int kullaniciid;

        private void FrmAtıkBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                var urun = _context.Urunler.FirstOrDefault(u => u.urun_turu == cmb_tür.Text);
                var sehir = _context.Sehirler.FirstOrDefault(s => s.sehir_adi == cmb_sehir.Text);
                var ilce = _context.Ilce.FirstOrDefault(i => i.ilce_adi == cmb_ilce.Text);

                if (urun != null && sehir != null && ilce != null)
                {
                    var existingKullaniciUrun = _context.Kullanicilar_urunler
                        .FirstOrDefault(ku => ku.kullanici_id == kullaniciid &&
                                              ku.urun_id == urun.urun_id &&
                                              ku.sehir_id == sehir.sehir_id &&
                                              ku.ilce_id == ilce.ilce_id);

                    if (existingKullaniciUrun != null)
                    {
                        existingKullaniciUrun.miktar += int.Parse(txt_miktar.Text);
                    }
                    else
                    {
                        var kullaniciUrun = new Kullanicilar_urunler
                        {
                            kullanici_id = kullaniciid,
                            urun_id = urun.urun_id,
                            sehir_id = sehir.sehir_id,
                            ilce_id = ilce.ilce_id,
                            miktar = int.Parse(txt_miktar.Text)
                        };

                    _context.Kullanicilar_urunler.Add(kullaniciUrun);
                    }

                    _context.SaveChanges();

                    MessageBox.Show("Geri Dönüşüme Katkıda Bulunduğunuz İçin Teşekkür Ederiz.");
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bilgiler girin.");
                }
            
        }
    }
}
