namespace HastaneApp
{
    partial class FrmDoktorPaneli
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDoktorBilgileriGeri = new System.Windows.Forms.Button();
            this.BtnDoktorGuncelle = new System.Windows.Forms.Button();
            this.BtnDoktorSil = new System.Windows.Forms.Button();
            this.BtnDoktorEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwDoktorPanel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktorPanel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAd.Location = new System.Drawing.Point(107, 49);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(162, 33);
            this.TxtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC No :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(107, 163);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(162, 33);
            this.CmbBrans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(17, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(15, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Branş :";
            // 
            // MskTC
            // 
            this.MskTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskTC.Location = new System.Drawing.Point(107, 222);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(162, 33);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSoyad.Location = new System.Drawing.Point(107, 104);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(162, 33);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSifre.Location = new System.Drawing.Point(107, 281);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(162, 33);
            this.TxtSifre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDoktorBilgileriGeri);
            this.groupBox1.Controls.Add(this.BtnDoktorGuncelle);
            this.groupBox1.Controls.Add(this.BtnDoktorSil);
            this.groupBox1.Controls.Add(this.BtnDoktorEkle);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.CmbBrans);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 539);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // BtnDoktorBilgileriGeri
            // 
            this.BtnDoktorBilgileriGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDoktorBilgileriGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnDoktorBilgileriGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorBilgileriGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorBilgileriGeri.Location = new System.Drawing.Point(6, 359);
            this.BtnDoktorBilgileriGeri.Name = "BtnDoktorBilgileriGeri";
            this.BtnDoktorBilgileriGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnDoktorBilgileriGeri.TabIndex = 31;
            this.BtnDoktorBilgileriGeri.UseVisualStyleBackColor = false;
            this.BtnDoktorBilgileriGeri.Click += new System.EventHandler(this.BtnDoktorBilgileriGeri_Click);
            // 
            // BtnDoktorGuncelle
            // 
            this.BtnDoktorGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDoktorGuncelle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorGuncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDoktorGuncelle.Location = new System.Drawing.Point(5, 482);
            this.BtnDoktorGuncelle.Name = "BtnDoktorGuncelle";
            this.BtnDoktorGuncelle.Size = new System.Drawing.Size(318, 51);
            this.BtnDoktorGuncelle.TabIndex = 8;
            this.BtnDoktorGuncelle.Text = "Güncelle";
            this.BtnDoktorGuncelle.UseVisualStyleBackColor = false;
            this.BtnDoktorGuncelle.Click += new System.EventHandler(this.BtnDoktorGuncelle_Click);
            // 
            // BtnDoktorSil
            // 
            this.BtnDoktorSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDoktorSil.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorSil.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDoktorSil.Location = new System.Drawing.Point(167, 425);
            this.BtnDoktorSil.Name = "BtnDoktorSil";
            this.BtnDoktorSil.Size = new System.Drawing.Size(156, 51);
            this.BtnDoktorSil.TabIndex = 7;
            this.BtnDoktorSil.Text = "Sil";
            this.BtnDoktorSil.UseVisualStyleBackColor = false;
            this.BtnDoktorSil.Click += new System.EventHandler(this.BtnDoktorSil_Click);
            // 
            // BtnDoktorEkle
            // 
            this.BtnDoktorEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDoktorEkle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorEkle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDoktorEkle.Location = new System.Drawing.Point(5, 425);
            this.BtnDoktorEkle.Name = "BtnDoktorEkle";
            this.BtnDoktorEkle.Size = new System.Drawing.Size(156, 51);
            this.BtnDoktorEkle.TabIndex = 6;
            this.BtnDoktorEkle.Text = "Ekle";
            this.BtnDoktorEkle.UseVisualStyleBackColor = false;
            this.BtnDoktorEkle.Click += new System.EventHandler(this.BtnDoktorEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwDoktorPanel);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(341, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 539);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // dgwDoktorPanel
            // 
            this.dgwDoktorPanel.AllowUserToAddRows = false;
            this.dgwDoktorPanel.AllowUserToDeleteRows = false;
            this.dgwDoktorPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDoktorPanel.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwDoktorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwDoktorPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwDoktorPanel.ColumnHeadersHeight = 35;
            this.dgwDoktorPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwDoktorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDoktorPanel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwDoktorPanel.Location = new System.Drawing.Point(3, 29);
            this.dgwDoktorPanel.MultiSelect = false;
            this.dgwDoktorPanel.Name = "dgwDoktorPanel";
            this.dgwDoktorPanel.ReadOnly = true;
            this.dgwDoktorPanel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwDoktorPanel.RowTemplate.Height = 25;
            this.dgwDoktorPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDoktorPanel.Size = new System.Drawing.Size(912, 507);
            this.dgwDoktorPanel.TabIndex = 2;
            this.dgwDoktorPanel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDoktorPanel_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 100);
            this.panel1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(413, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doktor Kayıt Paneli";
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1266, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktorPanel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtAd;
        private Label label2;
        private ComboBox CmbBrans;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox MskTC;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgwDoktorPanel;
        private Button BtnDoktorEkle;
        private Button BtnDoktorGuncelle;
        private Button BtnDoktorSil;
        private Button BtnDoktorBilgileriGeri;
        private Panel panel1;
        private Label label6;
    }
}