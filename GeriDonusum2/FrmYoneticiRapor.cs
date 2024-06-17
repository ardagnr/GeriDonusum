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
        private GeriDonusumContext _context;
        public FrmYoneticiRapor()
        {
            InitializeComponent();
            _context = new GeriDonusumContext();
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
        }
    }
}
