namespace HastaneApp
{
    partial class FrmDoktorDetay
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
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwRandevuListesi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDoktorDetayGeri = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListesi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(8, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAdSoyad.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAdSoyad.Location = new System.Drawing.Point(189, 102);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(96, 25);
            this.LblAdSoyad.TabIndex = 19;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad Soyad :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTC.Location = new System.Drawing.Point(189, 53);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(144, 25);
            this.LblTC.TabIndex = 17;
            this.LblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(30, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tc Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(8, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // RchSikayet
            // 
            this.RchSikayet.Location = new System.Drawing.Point(11, 32);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(302, 220);
            this.RchSikayet.TabIndex = 1;
            this.RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwRandevuListesi);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox3.Location = new System.Drawing.Point(355, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1295, 598);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dgwRandevuListesi
            // 
            this.dgwRandevuListesi.AllowUserToAddRows = false;
            this.dgwRandevuListesi.AllowUserToDeleteRows = false;
            this.dgwRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwRandevuListesi.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwRandevuListesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwRandevuListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwRandevuListesi.ColumnHeadersHeight = 35;
            this.dgwRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRandevuListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwRandevuListesi.Location = new System.Drawing.Point(3, 29);
            this.dgwRandevuListesi.MultiSelect = false;
            this.dgwRandevuListesi.Name = "dgwRandevuListesi";
            this.dgwRandevuListesi.ReadOnly = true;
            this.dgwRandevuListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwRandevuListesi.RowTemplate.Height = 25;
            this.dgwRandevuListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwRandevuListesi.Size = new System.Drawing.Size(1289, 566);
            this.dgwRandevuListesi.TabIndex = 1;
            this.dgwRandevuListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRandevuListesi_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDoktorDetayGeri);
            this.groupBox4.Controls.Add(this.BtnDuyurular);
            this.groupBox4.Controls.Add(this.BtnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox4.Location = new System.Drawing.Point(11, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BtnDoktorDetayGeri
            // 
            this.BtnDoktorDetayGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDoktorDetayGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnDoktorDetayGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorDetayGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorDetayGeri.Location = new System.Drawing.Point(225, 59);
            this.BtnDoktorDetayGeri.Name = "BtnDoktorDetayGeri";
            this.BtnDoktorDetayGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnDoktorDetayGeri.TabIndex = 18;
            this.BtnDoktorDetayGeri.UseVisualStyleBackColor = false;
            this.BtnDoktorDetayGeri.Click += new System.EventHandler(this.BtnDoktorDetayGeri_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDuyurular.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuyurular.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDuyurular.Location = new System.Drawing.Point(11, 94);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(162, 51);
            this.BtnDuyurular.TabIndex = 3;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = false;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGuncelle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnGuncelle.Location = new System.Drawing.Point(11, 32);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(162, 51);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Bilgi Düzenle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1655, 100);
            this.panel1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(497, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doktor Randevu Detay";
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1655, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListesi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label2;
        private Label LblTC;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgwRandevuListesi;
        private RichTextBox RchSikayet;
        private GroupBox groupBox4;
        private Button BtnDuyurular;
        private Button BtnGuncelle;
        private Panel panel1;
        private Label label6;
        private Button BtnDoktorDetayGeri;
    }
}