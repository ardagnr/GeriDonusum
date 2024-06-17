namespace GeriDonusum2
{
    partial class FrmAtıkBilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtıkBilgileri));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.cmb_tür = new System.Windows.Forms.ComboBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(160, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangi Geri Dönüştürme Merkezini Kullandınız :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(106, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geri Dönüştürdüğünüz Malzemenin Türü Ve Miktarı Nedir :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(121, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(391, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            "Ankara"});
            this.cmb_sehir.Location = new System.Drawing.Point(171, 142);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(153, 27);
            this.cmb_sehir.TabIndex = 7;
            this.cmb_sehir.Text = "Şehir Seçiniz";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.cmb_ilce.FormattingEnabled = true;
            this.cmb_ilce.Items.AddRange(new object[] {
            "Gölbaşı",
            "Çankaya",
            "Altındağ",
            "Etimesgut",
            "Yenimahalle"});
            this.cmb_ilce.Location = new System.Drawing.Point(441, 142);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(153, 27);
            this.cmb_ilce.TabIndex = 8;
            this.cmb_ilce.Text = "İlçe Seçiniz";
            // 
            // cmb_tür
            // 
            this.cmb_tür.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.cmb_tür.FormattingEnabled = true;
            this.cmb_tür.Items.AddRange(new object[] {
            "Plastik Atıklar",
            "Cam Atıklar",
            "Metal Atıklar",
            "Kağıt Atıklar",
            "Elektronik Atıklar"});
            this.cmb_tür.Location = new System.Drawing.Point(171, 283);
            this.cmb_tür.Name = "cmb_tür";
            this.cmb_tür.Size = new System.Drawing.Size(153, 27);
            this.cmb_tür.TabIndex = 9;
            this.cmb_tür.Text = "Tür Seçiniz";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.txt_miktar.Location = new System.Drawing.Point(441, 283);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(153, 26);
            this.txt_miktar.TabIndex = 10;
            this.txt_miktar.Text = "Miktar Giriniz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(304, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(261, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Raporlar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.BackColor = System.Drawing.Color.Khaki;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(12, 53);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(0, 19);
            this.lbl_kullaniciAdi.TabIndex = 14;
            // 
            // FrmAtıkBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(727, 482);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.cmb_tür);
            this.Controls.Add(this.cmb_ilce);
            this.Controls.Add(this.cmb_sehir);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAtıkBilgileri";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmAtıkBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private System.Windows.Forms.ComboBox cmb_tür;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
    }
}