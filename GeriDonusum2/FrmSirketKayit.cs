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
        private GeriDonusumContext _context;
        public FrmSirketKayit()
        {
            InitializeComponent();
            _context = new GeriDonusumContext();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new GeriDonusumContext())
                {
                    var sirket = context.Sirketler.FirstOrDefault(s => s.sirket_adi == txt_SirketAdi.Text);

                    var yeniEleman = new Elemanlar
                    {
                        eleman_adi = txt_ad.Text,
                        pozisyon = txt_pozisyon.Text,
                        sirket_id = sirket.sirket_id,
                        eleman_telefon =msk_telno.Text,
                        sifre = txt_sifre.Text
                    };

                    _context.Elemanlar.Add(yeniEleman);
                    _context.SaveChanges();
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

        private void FrmSirketKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
