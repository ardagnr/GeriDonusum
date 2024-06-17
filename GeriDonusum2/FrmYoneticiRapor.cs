using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeriDonusum2.Models;

namespace GeriDonusum2
{
    public partial class FrmYoneticiRapor : Form
    {
        private GeriDonusumDbContext _context;
        public FrmYoneticiRapor()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TumVeriler();

            var query = from ku in _context.Kullanicilar_urunler
                        join u in _context.Urunler on ku.urun_id equals u.urun_id
                        group ku by new { u.urun_turu, u.geridonusum_fiyati } into g
                        select new
                        {
                            UrunTuru = g.Key.urun_turu,
                            ToplamKar = g.Sum(x => x.miktar * g.Key.geridonusum_fiyati)
                        };

            var data = query.ToList();
            dataGridView3.DataSource = data;

            dataGridView3.Columns["UrunTuru"].HeaderText = "Ürün Türü";
            dataGridView3.Columns["ToplamKar"].HeaderText = "Toplam Kar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecilenVeriler();

            var query = from ku in _context.Kullanicilar_urunler
                        join u in _context.Urunler on ku.urun_id equals u.urun_id
                        join s in _context.Sehirler on ku.sehir_id equals s.sehir_id
                        join i in _context.Ilce on ku.ilce_id equals i.ilce_id
                        where s.sehir_adi == cmb_sehir.Text && i.ilce_adi == cmb_ilce.Text
                        group ku by new { u.urun_turu, u.geridonusum_fiyati } into g
                        select new
                        {
                            UrunTuru = g.Key.urun_turu,
                            ToplamKar = g.Sum(x => x.miktar * g.Key.geridonusum_fiyati)
                        };

            var data = query.ToList();
            dataGridView3.DataSource = data;

            dataGridView3.Columns["UrunTuru"].HeaderText = "Ürün Türü";
            dataGridView3.Columns["ToplamKar"].HeaderText = "Toplam Kar";

        }
        private void SecilenVeriler()
        {
            string sehirAdi = cmb_sehir.Text.Trim();
            string ilceAdi = cmb_ilce.Text.Trim();
            var query = from ku in _context.Kullanicilar_urunler
                        join k in _context.Kullanicilar on ku.kullanici_id equals k.kullanici_id
                        join u in _context.Urunler on ku.urun_id equals u.urun_id
                        join s in _context.Sehirler on ku.sehir_id equals s.sehir_id
                        join i in _context.Ilce on ku.ilce_id equals i.ilce_id
                        where (string.IsNullOrEmpty(sehirAdi) || s.sehir_adi == sehirAdi)
                           && (string.IsNullOrEmpty(ilceAdi) || i.ilce_adi == ilceAdi)
                        select new
                        {
                            KullaniciAdi = k.kullanici_adi,
                            UrunTuru = u.urun_turu,
                            Miktar = ku.miktar,
                            SehirAdi = s.sehir_adi,
                            IlceAdi = i.ilce_adi
                        };

            var data = query.ToList();
            dataGridView1.DataSource = data;

            dataGridView1.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["UrunTuru"].HeaderText = "Ürün Türü";
            dataGridView1.Columns["Miktar"].HeaderText = "Miktar";
            dataGridView1.Columns["SehirAdi"].HeaderText = "Şehir Adı";
            dataGridView1.Columns["IlceAdi"].HeaderText = "İlçe Adı";
        }
        private void TumVeriler()
        {
            var query = from ku in _context.Kullanicilar_urunler
                        join k in _context.Kullanicilar on ku.kullanici_id equals k.kullanici_id
                        join u in _context.Urunler on ku.urun_id equals u.urun_id
                        join s in _context.Sehirler on ku.sehir_id equals s.sehir_id
                        join i in _context.Ilce on ku.ilce_id equals i.ilce_id
                        select new
                        {
                            KullaniciAdi = k.kullanici_adi,
                            UrunTuru = u.urun_turu,
                            Miktar = ku.miktar,
                            SehirAdi = s.sehir_adi,
                            IlceAdi = i.ilce_adi
                        };

            var data = query.ToList();
            dataGridView1.DataSource = data;

            dataGridView1.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["UrunTuru"].HeaderText = "Ürün Türü";
            dataGridView1.Columns["Miktar"].HeaderText = "Miktar";
            dataGridView1.Columns["SehirAdi"].HeaderText = "Şehir Adı";
            dataGridView1.Columns["IlceAdi"].HeaderText = "İlçe Adı";
        }
        private void Atiklar()
        {
            var query = from u in _context.Urunler
                        select new
                        {
                            UrunTuru = u.urun_turu,
                            SatisFiyat = u.satis_fiyat,
                            GeriDonusumFiyati = u.geridonusum_fiyati
                        };

            var data = query.ToList();
            dataGridView2.DataSource = data;

            dataGridView2.Columns["UrunTuru"].HeaderText = "Ürün Türü";
            dataGridView2.Columns["SatisFiyat"].HeaderText = "Satış Fiyatı";
            dataGridView2.Columns["GeriDonusumFiyati"].HeaderText = "Geri Dönüşüm Fiyatı";
        }

        private void FrmYoneticiRapor_Load(object sender, EventArgs e)
        {
            Atiklar();
            Urungetir();
        }
        
        private void Urungetir()
        {
            cmb_sehir.Items.Clear();

            var sehirler = _context.Sehirler.Select(s => s.sehir_adi).Distinct().ToList();
            foreach (var sehir in sehirler)
            {
                if (!cmb_sehir.Items.Contains(sehir))
                {
                    cmb_sehir.Items.Add(sehir);
                }
            }
            cmb_ilce.Items.Clear();

            var ilceler = _context.Ilce.Select(i => i.ilce_adi).Distinct().ToList();
            foreach (var ilce in ilceler)
            {
 
                if (!cmb_ilce.Items.Contains(ilce))
                {
                    cmb_ilce.Items.Add(ilce);
                }
            }
        }
        private void YeniMerkez()
        {
            string sehirAdi = txt_sehir.Text.Trim();
            string ilceAdi = txt_ilce.Text.Trim();

            var existingSehir = _context.Sehirler.FirstOrDefault(s => s.sehir_adi == sehirAdi);
            if (existingSehir == null)
            {
                var yeniSehir = new Sehirlers { sehir_adi = sehirAdi };
                _context.Sehirler.Add(yeniSehir);
                _context.SaveChanges();
            }
            var existingIlce = _context.Ilce.FirstOrDefault(i => i.ilce_adi == ilceAdi);
            if (existingIlce == null)
            {
 
                var yeniIlce = new Ilces { ilce_adi = ilceAdi };
                _context.Ilce.Add(yeniIlce);
                _context.SaveChanges();
            }
            MessageBox.Show("Yeni Geri Dönüşüm Merkezi Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            YeniMerkez();
            Urungetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSirketGiris fr = new FrmSirketGiris();
            fr.Show();
            this.Hide();
        }
    }
}
