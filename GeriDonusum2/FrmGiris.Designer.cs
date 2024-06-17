namespace GeriDonusum2
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yonetici.BackgroundImage")));
            this.btn_yonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yonetici.Location = new System.Drawing.Point(154, 129);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(194, 166);
            this.btn_yonetici.TabIndex = 0;
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kullanici.BackgroundImage")));
            this.btn_kullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kullanici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kullanici.Location = new System.Drawing.Point(420, 129);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(194, 166);
            this.btn_kullanici.TabIndex = 2;
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(220, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giriş Seçeneklerinden Birini Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yönetici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(478, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(751, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_yonetici);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

