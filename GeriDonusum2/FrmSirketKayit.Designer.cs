namespace GeriDonusum2
{
    partial class FrmSirketKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SirketAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_pozisyon = new System.Windows.Forms.TextBox();
            this.msk_telno = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.txt_SirketAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_kayit);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_pozisyon);
            this.groupBox1.Controls.Add(this.msk_telno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(129, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(411, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şirket Kullanıcı Kayıt";
            // 
            // txt_SirketAdi
            // 
            this.txt_SirketAdi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SirketAdi.Location = new System.Drawing.Point(179, 313);
            this.txt_SirketAdi.Name = "txt_SirketAdi";
            this.txt_SirketAdi.Size = new System.Drawing.Size(165, 26);
            this.txt_SirketAdi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(72, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şirket Adı :";
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(105, 370);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(177, 30);
            this.btn_kayit.TabIndex = 9;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(179, 150);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(165, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(179, 197);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(165, 26);
            this.txt_sifre.TabIndex = 2;
            // 
            // txt_pozisyon
            // 
            this.txt_pozisyon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pozisyon.Location = new System.Drawing.Point(179, 238);
            this.txt_pozisyon.Name = "txt_pozisyon";
            this.txt_pozisyon.Size = new System.Drawing.Size(165, 26);
            this.txt_pozisyon.TabIndex = 3;
            // 
            // msk_telno
            // 
            this.msk_telno.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk_telno.Location = new System.Drawing.Point(179, 278);
            this.msk_telno.Mask = "(999) 000-0000";
            this.msk_telno.Name = "msk_telno";
            this.msk_telno.Size = new System.Drawing.Size(165, 26);
            this.msk_telno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(9, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(81, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pozisyon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(115, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(52, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // FrmSirketKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(668, 524);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmSirketKayit";
            this.Text = "FrmSirketKayit";
            this.Load += new System.EventHandler(this.FrmSirketKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_pozisyon;
        private System.Windows.Forms.MaskedTextBox msk_telno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SirketAdi;
        private System.Windows.Forms.Label label5;
    }
}