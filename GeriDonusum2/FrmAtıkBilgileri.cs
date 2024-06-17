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
        private GeriDonusumDbContext _context;
        public FrmAtıkBilgileri()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
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
            var urunler = _context.Urunler.Select(u => u.urun_turu).ToList();
            foreach (var urun in urunler)
            {
                cmb_tür.Items.Add(urun);
            }
            var sehirler = _context.Sehirler.Select(s => s.sehir_adi).ToList();
            foreach (var sehir in sehirler)
            {
                cmb_sehir.Items.Add(sehir);
            }

            var ilceler = _context.Ilce.Select(i => i.ilce_adi).ToList();
            foreach (var ilce in ilceler)
            {
                cmb_ilce.Items.Add(ilce);
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();
            fr.Show();
            this.Hide();
        }
    }
}
