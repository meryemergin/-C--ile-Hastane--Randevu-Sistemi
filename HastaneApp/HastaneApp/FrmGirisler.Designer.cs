namespace HastaneApp
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnHastaGiris = new System.Windows.Forms.Button();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.BtnSekreterGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            this.BtnHastaGiris.BackgroundImage = global::HastaneApp.Properties.Resources.Patient;
            this.BtnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHastaGiris.Location = new System.Drawing.Point(70, 192);
            this.BtnHastaGiris.Name = "BtnHastaGiris";
            this.BtnHastaGiris.Size = new System.Drawing.Size(202, 202);
            this.BtnHastaGiris.TabIndex = 0;
            this.BtnHastaGiris.UseVisualStyleBackColor = true;
            this.BtnHastaGiris.Click += new System.EventHandler(this.BtnHastaGiris_Click);
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.BackgroundImage = global::HastaneApp.Properties.Resources.Doctor;
            this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDoktorGiris.Location = new System.Drawing.Point(317, 192);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(202, 202);
            this.BtnDoktorGiris.TabIndex = 1;
            this.BtnDoktorGiris.UseVisualStyleBackColor = true;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // BtnSekreterGiris
            // 
            this.BtnSekreterGiris.BackgroundImage = global::HastaneApp.Properties.Resources.secretary;
            this.BtnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSekreterGiris.Location = new System.Drawing.Point(564, 192);
            this.BtnSekreterGiris.Name = "BtnSekreterGiris";
            this.BtnSekreterGiris.Size = new System.Drawing.Size(202, 202);
            this.BtnSekreterGiris.TabIndex = 2;
            this.BtnSekreterGiris.UseVisualStyleBackColor = true;
            this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(133, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(375, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(612, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 136);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HastaneApp.Properties.Resources.cardiogram;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 110);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(292, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "MRE HOSPİTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(302, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "GİRİŞ EKRANI";
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Crimson;
            this.BtnCikis.BackgroundImage = global::HastaneApp.Properties.Resources.cikis;
            this.BtnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCikis.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCikis.Location = new System.Drawing.Point(805, 479);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(65, 69);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(882, 560);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGiris);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.BtnHastaGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnHastaGiris;
        private Button BtnDoktorGiris;
        private Button BtnSekreterGiris;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button BtnCikis;
    }
}