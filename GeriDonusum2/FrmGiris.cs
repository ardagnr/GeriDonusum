using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriDonusum2
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();
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
