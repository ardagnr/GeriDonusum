using System;
using System.Data.Entity;
using System.Windows.Forms;
using GeriDonusum2.Models;

namespace GeriDonusum2
{
    public partial class FrmKullaniciKayit : Form
    {
        private GeriDonusumContext _context;

        public FrmKullaniciKayit()
        {
            InitializeComponent();
            _context = new GeriDonusumContext();
        }
        private void FrmKullaniciKayit_Load (object sender, EventArgs e)
        {

        }
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                
                var kullanici = new Kullanicilars
                {
                    kullanici_adi = txt_ad.Text,
                    sifre = txt_sifre.Text,
                    email = txt_email.Text,
                    olusturma_tarihi = DateTime.Now.ToString(), 
                    telefon_numarasi = msk_telno.Text
                };

                _context.Kullanicilar.Add(kullanici);
                _context.SaveChanges();

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

        private void FrmKullaniciKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
