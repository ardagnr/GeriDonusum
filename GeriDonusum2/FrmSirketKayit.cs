using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeriDonusum2.Models;

namespace GeriDonusum2
{
    public partial class FrmSirketKayit : Form
    {
        private GeriDonusumDbContext _context;
        public FrmSirketKayit()
        {
            InitializeComponent();
            _context = new GeriDonusumDbContext();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new GeriDonusumDbContext())
                {
                    string secilenPozisyonAdi = cmb_pozisyon.Text;

                    var sirket = context.Sirketler.FirstOrDefault(s => s.sirket_adi == cmb_sirketadi.Text);

                    if (sirket == null)
                    {
 
                        sirket = new Sirketler { sirket_adi = cmb_sirketadi.Text };
                        context.Sirketler.Add(sirket);
                        context.SaveChanges(); 
                    }

                    var pozisyon = context.Pozisyonlar.FirstOrDefault(p => p.pozisyon_adi == secilenPozisyonAdi);

                    var yeniEleman = new Elemanlar
                    {
                        eleman_adi = txt_ad.Text,
                        pozisyon_id = pozisyon != null ? pozisyon.pozisyon_id : 0,
                        sirket_id = sirket.sirket_id,
                        eleman_telefon = msk_telno.Text,
                        sifre = txt_sifre.Text
                    };

                    context.Elemanlar.Add(yeniEleman);
                    context.SaveChanges();
                }

                MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir!!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _context.Dispose();
            }

        }
        private void LoadPozisyonlar()
        {
            var pozisyonlar = _context.Pozisyonlar.ToList();
            foreach (var pozisyon in pozisyonlar)
            {
                cmb_pozisyon.Items.Add(pozisyon.pozisyon_adi);
            }
        }

        private void LoadSirketAdlari()
        {
            var sirketler = _context.Sirketler.ToList();

            foreach (var sirket in sirketler)
            {
                cmb_sirketadi.Items.Add(sirket.sirket_adi);
            }
        }

        private void FrmSirketKayit_Load(object sender, EventArgs e)
        {
            LoadPozisyonlar();
            LoadSirketAdlari();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSirketGiris fr = new FrmSirketGiris();
            fr.Show();
            this.Hide();
        }
    }
}
