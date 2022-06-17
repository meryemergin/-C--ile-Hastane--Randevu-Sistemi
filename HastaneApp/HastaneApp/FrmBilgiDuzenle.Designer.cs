namespace HastaneApp
{
    partial class FrmBilgiDuzenle
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
            this.BtnHastaBilgiGuncelleGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnHastaBilgiGuncelle = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHastaBilgiGuncelleGeri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.BtnHastaBilgiGuncelle);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbCinsiyet);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 429);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // BtnHastaBilgiGuncelleGeri
            // 
            this.BtnHastaBilgiGuncelleGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnHastaBilgiGuncelleGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnHastaBilgiGuncelleGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaBilgiGuncelleGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHastaBilgiGuncelleGeri.Location = new System.Drawing.Point(465, 363);
            this.BtnHastaBilgiGuncelleGeri.Name = "BtnHastaBilgiGuncelleGeri";
            this.BtnHastaBilgiGuncelleGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnHastaBilgiGuncelleGeri.TabIndex = 20;
            this.BtnHastaBilgiGuncelleGeri.UseVisualStyleBackColor = false;
            this.BtnHastaBilgiGuncelleGeri.Click += new System.EventHandler(this.BtnHastaBilgiGuncelleGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad :";
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MskTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskTC.Location = new System.Drawing.Point(170, 137);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(162, 33);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // BtnHastaBilgiGuncelle
            // 
            this.BtnHastaBilgiGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnHastaBilgiGuncelle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHastaBilgiGuncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnHastaBilgiGuncelle.Location = new System.Drawing.Point(170, 334);
            this.BtnHastaBilgiGuncelle.Name = "BtnHastaBilgiGuncelle";
            this.BtnHastaBilgiGuncelle.Size = new System.Drawing.Size(162, 50);
            this.BtnHastaBilgiGuncelle.TabIndex = 7;
            this.BtnHastaBilgiGuncelle.Text = "Güncelle";
            this.BtnHastaBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnHastaBilgiGuncelle.Click += new System.EventHandler(this.BtnHastaBilgiGuncelle_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAd.Location = new System.Drawing.Point(170, 38);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(162, 33);
            this.TxtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(28, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(28, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No :";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(170, 281);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(162, 33);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSoyad.Location = new System.Drawing.Point(170, 89);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(162, 33);
            this.TxtSoyad.TabIndex = 2;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MskTelefon.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskTelefon.Location = new System.Drawing.Point(170, 194);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(162, 33);
            this.MskTelefon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(28, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon No :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSifre.Location = new System.Drawing.Point(170, 242);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(162, 33);
            this.TxtSifre.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 100);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(528, 58);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hasta Bilgi Güncelleme";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnHastaBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBilgiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private MaskedTextBox MskTC;
        private Button BtnHastaBilgiGuncelle;
        private TextBox TxtAd;
        private Label label6;
        private Label label2;
        private ComboBox CmbCinsiyet;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTelefon;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox TxtSifre;
        private Panel panel1;
        private Label label7;
        private Button BtnHastaBilgiGuncelleGeri;
    }
}