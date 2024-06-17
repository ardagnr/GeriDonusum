using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using GeriDonusum2.Models;

namespace GeriDonusum2
{
    public partial class FrmKullaniciGiris : Form
    {
        private GeriDonusumDbContext _context;

        public FrmKullaniciGiris()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciKayit fr = new FrmKullaniciKayit();
            fr.Show();
        }
        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.kullanici_adi == txt_ad.Text && k.sifre == txt_sifre.Text);

            if (kullanici != null)
            {
                FrmAtıkBilgileri fr = new FrmAtıkBilgileri();
                fr.kullaniciid = kullanici.kullanici_id;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad & Şifre");
            }
        }

        private void FrmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }
    }
}
