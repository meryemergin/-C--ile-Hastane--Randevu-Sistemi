namespace HastaneApp
{
    partial class FrmSekreterDetay
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
            this.LblDoktorTC = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuKaydet = new System.Windows.Forms.Button();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgwDoktorlar = new System.Windows.Forms.DataGridView();
            this.BtnSekreterDetayGeri = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktorlar)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDoktorTC);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblDoktorTC
            // 
            this.LblDoktorTC.AutoSize = true;
            this.LblDoktorTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDoktorTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDoktorTC.Location = new System.Drawing.Point(138, 182);
            this.LblDoktorTC.Name = "LblDoktorTC";
            this.LblDoktorTC.Size = new System.Drawing.Size(49, 25);
            this.LblDoktorTC.TabIndex = 15;
            this.LblDoktorTC.Text = "DTC";
            this.LblDoktorTC.Visible = false;
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAdSoyad.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAdSoyad.Location = new System.Drawing.Point(138, 131);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(96, 25);
            this.LblAdSoyad.TabIndex = 14;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblTC.Location = new System.Drawing.Point(106, 71);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(144, 25);
            this.LblTC.TabIndex = 13;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TC No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDuyuruOlustur.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuyuruOlustur.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(0, 242);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(390, 51);
            this.BtnDuyuruOlustur.TabIndex = 10;
            this.BtnDuyuruOlustur.Text = "Oluştur";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = false;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 32);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(384, 204);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnRandevuKaydet);
            this.groupBox3.Controls.Add(this.CmbDoktor);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox3.Location = new System.Drawing.Point(414, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 530);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnRandevuKaydet
            // 
            this.BtnRandevuKaydet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRandevuKaydet.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandevuKaydet.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnRandevuKaydet.Location = new System.Drawing.Point(6, 469);
            this.BtnRandevuKaydet.Name = "BtnRandevuKaydet";
            this.BtnRandevuKaydet.Size = new System.Drawing.Size(434, 51);
            this.BtnRandevuKaydet.TabIndex = 8;
            this.BtnRandevuKaydet.Text = "Randevuyu Kaydet";
            this.BtnRandevuKaydet.UseVisualStyleBackColor = false;
            this.BtnRandevuKaydet.Click += new System.EventHandler(this.BtnRandevuKaydet_Click);
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(115, 317);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(121, 33);
            this.CmbDoktor.TabIndex = 5;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(115, 255);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(121, 33);
            this.CmbBrans.TabIndex = 4;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskSaat.Location = new System.Drawing.Point(115, 194);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(74, 33);
            this.MskSaat.TabIndex = 3;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskTarih.Location = new System.Drawing.Point(115, 132);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(162, 33);
            this.MskTarih.TabIndex = 2;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txtid.Location = new System.Drawing.Point(115, 71);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(162, 33);
            this.Txtid.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(28, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(29, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Doktor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(29, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Branş :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(29, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Saat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(29, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(29, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "id :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwBranslar);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox4.Location = new System.Drawing.Point(869, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 329);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dgwBranslar
            // 
            this.dgwBranslar.AllowUserToAddRows = false;
            this.dgwBranslar.AllowUserToDeleteRows = false;
            this.dgwBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBranslar.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwBranslar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwBranslar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwBranslar.ColumnHeadersHeight = 35;
            this.dgwBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBranslar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBranslar.Location = new System.Drawing.Point(3, 29);
            this.dgwBranslar.MultiSelect = false;
            this.dgwBranslar.Name = "dgwBranslar";
            this.dgwBranslar.ReadOnly = true;
            this.dgwBranslar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwBranslar.RowTemplate.Height = 25;
            this.dgwBranslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBranslar.Size = new System.Drawing.Size(655, 297);
            this.dgwBranslar.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.BtnDuyurular);
            this.groupBox5.Controls.Add(this.BtnRandevuListe);
            this.groupBox5.Controls.Add(this.BtnBransPanel);
            this.groupBox5.Controls.Add(this.BtnDoktorPanel);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox5.Location = new System.Drawing.Point(12, 642);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(732, 187);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(730, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDuyurular.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuyurular.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDuyurular.Location = new System.Drawing.Point(372, 103);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(352, 65);
            this.BtnDuyurular.TabIndex = 14;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = false;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRandevuListe.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandevuListe.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnRandevuListe.Location = new System.Drawing.Point(372, 32);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(352, 65);
            this.BtnRandevuListe.TabIndex = 13;
            this.BtnRandevuListe.Text = "Randevu Listesi";
            this.BtnRandevuListe.UseVisualStyleBackColor = false;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBransPanel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBransPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBransPanel.Location = new System.Drawing.Point(8, 103);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(352, 65);
            this.BtnBransPanel.TabIndex = 12;
            this.BtnBransPanel.Text = "Branş Paneli";
            this.BtnBransPanel.UseVisualStyleBackColor = false;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDoktorPanel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDoktorPanel.Location = new System.Drawing.Point(6, 32);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(352, 65);
            this.BtnDoktorPanel.TabIndex = 11;
            this.BtnDoktorPanel.Text = "Doktor Paneli";
            this.BtnDoktorPanel.UseVisualStyleBackColor = false;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgwDoktorlar);
            this.groupBox6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox6.Location = new System.Drawing.Point(869, 441);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(658, 388);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dgwDoktorlar
            // 
            this.dgwDoktorlar.AllowUserToAddRows = false;
            this.dgwDoktorlar.AllowUserToDeleteRows = false;
            this.dgwDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDoktorlar.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwDoktorlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwDoktorlar.ColumnHeadersHeight = 35;
            this.dgwDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDoktorlar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwDoktorlar.Location = new System.Drawing.Point(3, 29);
            this.dgwDoktorlar.MultiSelect = false;
            this.dgwDoktorlar.Name = "dgwDoktorlar";
            this.dgwDoktorlar.ReadOnly = true;
            this.dgwDoktorlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwDoktorlar.RowTemplate.Height = 25;
            this.dgwDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDoktorlar.Size = new System.Drawing.Size(652, 356);
            this.dgwDoktorlar.TabIndex = 2;
            // 
            // BtnSekreterDetayGeri
            // 
            this.BtnSekreterDetayGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSekreterDetayGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnSekreterDetayGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterDetayGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSekreterDetayGeri.Location = new System.Drawing.Point(16, 84);
            this.BtnSekreterDetayGeri.Name = "BtnSekreterDetayGeri";
            this.BtnSekreterDetayGeri.Size = new System.Drawing.Size(80, 80);
            this.BtnSekreterDetayGeri.TabIndex = 17;
            this.BtnSekreterDetayGeri.UseVisualStyleBackColor = false;
            this.BtnSekreterDetayGeri.Click += new System.EventHandler(this.BtnSekreterDetayGeri_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BtnSekreterDetayGeri);
            this.groupBox8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox8.Location = new System.Drawing.Point(753, 642);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(113, 187);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Geri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(493, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sekreter Detay Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 100);
            this.panel1.TabIndex = 10;
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1542, 835);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktorlar)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label LblTC;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Button BtnDuyuruOlustur;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox4;
        private TextBox Txtid;
        private MaskedTextBox MskTarih;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private Button BtnRandevuKaydet;
        private GroupBox groupBox5;
        private DataGridView dgwBranslar;
        private GroupBox groupBox6;
        private DataGridView dgwDoktorlar;
        private Button BtnBransPanel;
        private Button BtnDoktorPanel;
        private Button BtnRandevuListe;
        private Button BtnDuyurular;
        private Button BtnSekreterDetayGeri;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label LblDoktorTC;
        private Label label4;
        private Panel panel1;
    }
}