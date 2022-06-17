namespace HastaneApp
{
    partial class FrmBrans
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwBrans = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBransDuzenleGeri = new System.Windows.Forms.Button();
            this.BtnBransGuncelle = new System.Windows.Forms.Button();
            this.BtnBransSil = new System.Windows.Forms.Button();
            this.BtnBransEkle = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtBrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrans)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwBrans);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(344, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 340);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // dgwBrans
            // 
            this.dgwBrans.AllowUserToAddRows = false;
            this.dgwBrans.AllowUserToDeleteRows = false;
            this.dgwBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBrans.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwBrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwBrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwBrans.ColumnHeadersHeight = 35;
            this.dgwBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBrans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBrans.Location = new System.Drawing.Point(3, 29);
            this.dgwBrans.MultiSelect = false;
            this.dgwBrans.Name = "dgwBrans";
            this.dgwBrans.ReadOnly = true;
            this.dgwBrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwBrans.RowTemplate.Height = 25;
            this.dgwBrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBrans.Size = new System.Drawing.Size(715, 308);
            this.dgwBrans.TabIndex = 2;
            this.dgwBrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBrans_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnBransDuzenleGeri);
            this.groupBox3.Controls.Add(this.BtnBransGuncelle);
            this.groupBox3.Controls.Add(this.BtnBransSil);
            this.groupBox3.Controls.Add(this.BtnBransEkle);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.TxtBrans);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox3.Location = new System.Drawing.Point(3, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 340);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // BtnBransDuzenleGeri
            // 
            this.BtnBransDuzenleGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBransDuzenleGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnBransDuzenleGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBransDuzenleGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBransDuzenleGeri.Location = new System.Drawing.Point(11, 160);
            this.BtnBransDuzenleGeri.Name = "BtnBransDuzenleGeri";
            this.BtnBransDuzenleGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnBransDuzenleGeri.TabIndex = 29;
            this.BtnBransDuzenleGeri.UseVisualStyleBackColor = false;
            this.BtnBransDuzenleGeri.Click += new System.EventHandler(this.BtnBransDuzenleGeri_Click);
            // 
            // BtnBransGuncelle
            // 
            this.BtnBransGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBransGuncelle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBransGuncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBransGuncelle.Location = new System.Drawing.Point(11, 283);
            this.BtnBransGuncelle.Name = "BtnBransGuncelle";
            this.BtnBransGuncelle.Size = new System.Drawing.Size(318, 51);
            this.BtnBransGuncelle.TabIndex = 5;
            this.BtnBransGuncelle.Text = "Güncelle";
            this.BtnBransGuncelle.UseVisualStyleBackColor = false;
            this.BtnBransGuncelle.Click += new System.EventHandler(this.BtnBransGuncelle_Click);
            // 
            // BtnBransSil
            // 
            this.BtnBransSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBransSil.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBransSil.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBransSil.Location = new System.Drawing.Point(173, 226);
            this.BtnBransSil.Name = "BtnBransSil";
            this.BtnBransSil.Size = new System.Drawing.Size(156, 51);
            this.BtnBransSil.TabIndex = 4;
            this.BtnBransSil.Text = "Sil";
            this.BtnBransSil.UseVisualStyleBackColor = false;
            this.BtnBransSil.Click += new System.EventHandler(this.BtnBransSil_Click);
            // 
            // BtnBransEkle
            // 
            this.BtnBransEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnBransEkle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBransEkle.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBransEkle.Location = new System.Drawing.Point(11, 226);
            this.BtnBransEkle.Name = "BtnBransEkle";
            this.BtnBransEkle.Size = new System.Drawing.Size(156, 51);
            this.BtnBransEkle.TabIndex = 3;
            this.BtnBransEkle.Text = "Ekle";
            this.BtnBransEkle.UseVisualStyleBackColor = false;
            this.BtnBransEkle.Click += new System.EventHandler(this.BtnBransEkle_Click);
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txtid.Location = new System.Drawing.Point(138, 33);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(162, 33);
            this.Txtid.TabIndex = 1;
            // 
            // TxtBrans
            // 
            this.TxtBrans.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBrans.Location = new System.Drawing.Point(138, 88);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(162, 33);
            this.TxtBrans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Branş id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Branş Ad :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 100);
            this.panel1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(250, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(557, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Branş Düzenleme Paneli";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrans)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgwBrans;
        private GroupBox groupBox3;
        private Button BtnBransGuncelle;
        private Button BtnBransSil;
        private Button BtnBransEkle;
        private TextBox Txtid;
        private TextBox TxtBrans;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Button BtnBransDuzenleGeri;
    }
}