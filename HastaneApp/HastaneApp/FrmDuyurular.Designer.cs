namespace HastaneApp
{
    partial class FrmDuyurular
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwDuyurular = new System.Windows.Forms.DataGridView();
            this.BtnDuyurularGeri = new System.Windows.Forms.Button();
            this.BtnDuyuruSil = new System.Windows.Forms.Button();
            this.LblDuyuruid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(347, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Duyurular";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 108);
            this.panel1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwDuyurular);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(5, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 495);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // dgwDuyurular
            // 
            this.dgwDuyurular.AllowUserToAddRows = false;
            this.dgwDuyurular.AllowUserToDeleteRows = false;
            this.dgwDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDuyurular.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwDuyurular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwDuyurular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwDuyurular.ColumnHeadersHeight = 35;
            this.dgwDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDuyurular.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwDuyurular.Location = new System.Drawing.Point(3, 29);
            this.dgwDuyurular.MultiSelect = false;
            this.dgwDuyurular.Name = "dgwDuyurular";
            this.dgwDuyurular.ReadOnly = true;
            this.dgwDuyurular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwDuyurular.RowTemplate.Height = 25;
            this.dgwDuyurular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDuyurular.Size = new System.Drawing.Size(930, 463);
            this.dgwDuyurular.TabIndex = 1;
            this.dgwDuyurular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDuyurular_CellClick);
            // 
            // BtnDuyurularGeri
            // 
            this.BtnDuyurularGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDuyurularGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnDuyurularGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDuyurularGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuyurularGeri.Location = new System.Drawing.Point(8, 617);
            this.BtnDuyurularGeri.Name = "BtnDuyurularGeri";
            this.BtnDuyurularGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnDuyurularGeri.TabIndex = 27;
            this.BtnDuyurularGeri.UseVisualStyleBackColor = false;
            this.BtnDuyurularGeri.Click += new System.EventHandler(this.BtnDuyurularGeri_Click);
            // 
            // BtnDuyuruSil
            // 
            this.BtnDuyuruSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDuyuruSil.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuyuruSil.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDuyuruSil.Location = new System.Drawing.Point(74, 622);
            this.BtnDuyuruSil.Name = "BtnDuyuruSil";
            this.BtnDuyuruSil.Size = new System.Drawing.Size(156, 51);
            this.BtnDuyuruSil.TabIndex = 28;
            this.BtnDuyuruSil.Text = "Sil";
            this.BtnDuyuruSil.UseVisualStyleBackColor = false;
            this.BtnDuyuruSil.Click += new System.EventHandler(this.BtnDuyuruSil_Click);
            // 
            // LblDuyuruid
            // 
            this.LblDuyuruid.AutoSize = true;
            this.LblDuyuruid.Location = new System.Drawing.Point(255, 636);
            this.LblDuyuruid.Name = "LblDuyuruid";
            this.LblDuyuruid.Size = new System.Drawing.Size(17, 25);
            this.LblDuyuruid.TabIndex = 29;
            this.LblDuyuruid.Text = ".";
            this.LblDuyuruid.Visible = false;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 689);
            this.Controls.Add(this.LblDuyuruid);
            this.Controls.Add(this.BtnDuyuruSil);
            this.Controls.Add(this.BtnDuyurularGeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDuyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDuyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgwDuyurular;
        private Button BtnDuyurularGeri;
        private Button BtnDuyuruSil;
        private Label LblDuyuruid;
    }
}