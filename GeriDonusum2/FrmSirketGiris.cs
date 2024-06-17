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
        private GeriDonusumContext _context;
        public FrmSirketGiris()
        {
            InitializeComponent();
            _context = new GeriDonusumContext();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSirketKayit fr = new FrmSirketKayit();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yonetici = _context.Elemanlar.FirstOrDefault(k => k.eleman_adi == txt_ad.Text && k.sifre == txt_sifre.Text && k.pozisyon=="yönetici");

            if (yonetici != null)
            {
                FrmYoneticiRapor fr = new FrmYoneticiRapor();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad & Şifre veya Yetkiniz Bulunmuyor");
            }
        }
    }
}
