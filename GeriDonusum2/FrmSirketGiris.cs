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
    public partial class FrmSirketGiris : Form
    {
        private GeriDonusumDbContext _context;
        public FrmSirketGiris()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSirketKayit fr = new FrmSirketKayit();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yonetici = (from el in _context.Elemanlar
                            join poz in _context.Pozisyonlar on el.pozisyon_id equals poz.pozisyon_id
                            where el.eleman_adi == txt_ad.Text && el.sifre == txt_sifre.Text && poz.pozisyon_adi == "yönetici"
                            select el).FirstOrDefault();

            if (yonetici != null)
            {
                FrmYoneticiRapor fr = new FrmYoneticiRapor();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad & Şifre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmSirketGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
