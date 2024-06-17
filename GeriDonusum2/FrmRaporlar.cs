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
    public partial class FrmRaporlar : Form
    {
        private GeriDonusumDbContext _context;
        public FrmRaporlar()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
        }
        public int kullanicid;
        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
                var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.kullanici_id == kullanicid);
                if (kullanici != null)
                {
                    DataTable dt1= new DataTable();
                    dt1.Columns.Add("Kullanıcı Adı");
                    dt1.Columns.Add("Şifre");
                    dt1.Columns.Add("Email");
                    dt1.Columns.Add("Oluşturma Tarihi");
                    dt1.Columns.Add("Telefon Numarası");

                    dt1.Rows.Add( kullanici.kullanici_adi, kullanici.sifre,kullanici.email, kullanici.olusturma_tarihi, kullanici.telefon_numarasi);

                    dataGridView1.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show($"Kullanıcı ID'si {kullanicid} olan kullanıcı bulunamadı.");
                }

                var kullaniciUrunler = _context.Kullanicilar_urunler
                                            .Where(ku => ku.kullanici_id == kullanicid)
                                            .Join(_context.Sehirler,
                                                  ku => ku.sehir_id,
                                                  s => s.sehir_id,
                                                  (ku, s) => new { KullaniciUrun = ku, Sehir = s })
                                            .Join(_context.Ilce,
                                                  ku => ku.KullaniciUrun.ilce_id,
                                                  i => i.ilce_id,
                                                  (ku, i) => new { ku.KullaniciUrun, ku.Sehir, Ilce = i })
                                            .ToList();

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("Ürün Türü", typeof(string));
                dt2.Columns.Add("Şehir Adı", typeof(string));
                dt2.Columns.Add("İlçe Adı", typeof(string));
                dt2.Columns.Add("Miktar", typeof(int));

                foreach (var item in kullaniciUrunler)
                {
                    var urun = _context.Urunler.FirstOrDefault(u => u.urun_id == item.KullaniciUrun.urun_id);
                    if (urun != null)
                    {
                        dt2.Rows.Add(urun.urun_turu, item.Sehir.sehir_adi, item.Ilce.ilce_adi, item.KullaniciUrun.miktar);
                    }
                }
                dataGridView2.DataSource = dt2;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAtıkBilgileri fr = new FrmAtıkBilgileri();
            fr.Show();
            this.Hide();

        }
    }
}
