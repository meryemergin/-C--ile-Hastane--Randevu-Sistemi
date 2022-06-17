namespace HastaneApp
{
    partial class FrmHastaGiris
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
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHastaGirisGeri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnGirisYap.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGirisYap.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnGirisYap.Location = new System.Drawing.Point(203, 155);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(120, 51);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MskTC.ForeColor = System.Drawing.Color.SteelBlue;
            this.MskTC.Location = new System.Drawing.Point(203, 48);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(118, 33);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSifre.Location = new System.Drawing.Point(203, 98);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(118, 33);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LnkUyeOl.Location = new System.Drawing.Point(344, 106);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(73, 25);
            this.LnkUyeOl.TabIndex = 3;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Üye Ol";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(61, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(53, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta Giriş Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 100);
            this.panel1.TabIndex = 9;
            // 
            // BtnHastaGirisGeri
            // 
            this.BtnHastaGirisGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnHastaGirisGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnHastaGirisGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirisGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHastaGirisGeri.Location = new System.Drawing.Point(426, 187);
            this.BtnHastaGirisGeri.Name = "BtnHastaGirisGeri";
            this.BtnHastaGirisGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnHastaGirisGeri.TabIndex = 17;
            this.BtnHastaGirisGeri.UseVisualStyleBackColor = false;
            this.BtnHastaGirisGeri.Click += new System.EventHandler(this.BtnHastaGirisGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnHastaGirisGeri);
            this.groupBox1.Controls.Add(this.BtnGirisYap);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Controls.Add(this.LnkUyeOl);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 253);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(516, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnGirisYap;
        private MaskedTextBox MskTC;
        private TextBox TxtSifre;
        private LinkLabel LnkUyeOl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button BtnHastaGirisGeri;
        private GroupBox groupBox1;
    }
}