namespace GeriDonusum2
{
    partial class FrmYoneticiRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiRapor));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(14, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tüm Atıkları Gör";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(14, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Seçilen Şehir/İlçe Gör";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raporlar";
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
            this.cmb_ilce.Location = new System.Drawing.Point(553, 301);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(153, 27);
            this.cmb_ilce.TabIndex = 12;
            this.cmb_ilce.Text = "İlçe Seçiniz";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            "Ankara"});
            this.cmb_sehir.Location = new System.Drawing.Point(311, 301);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(153, 27);
            this.cmb_sehir.TabIndex = 11;
            this.cmb_sehir.Text = "Şehir Seçiniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 170);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(247, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(421, 170);
            this.dataGridView2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Atıklar Ve Fiyatları";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(579, 375);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(251, 170);
            this.dataGridView3.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(169, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Atık Bilgileri";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(592, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "Elde Edilen Para";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FrmYoneticiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(904, 580);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_ilce);
            this.Controls.Add(this.cmb_sehir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmYoneticiRapor";
            this.Text = "FrmYoneticiRapor";
            this.Load += new System.EventHandler(this.FrmYoneticiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}