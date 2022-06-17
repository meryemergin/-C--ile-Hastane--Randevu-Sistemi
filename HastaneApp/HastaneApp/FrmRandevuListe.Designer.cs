namespace HastaneApp
{
    partial class FrmRandevuListe
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
            this.dgwRandevuListe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRandevuListesiGeri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwRandevuListe);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgwRandevuListe
            // 
            this.dgwRandevuListe.AllowUserToAddRows = false;
            this.dgwRandevuListe.AllowUserToDeleteRows = false;
            this.dgwRandevuListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwRandevuListe.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwRandevuListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwRandevuListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgwRandevuListe.ColumnHeadersHeight = 35;
            this.dgwRandevuListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwRandevuListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRandevuListe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwRandevuListe.Location = new System.Drawing.Point(3, 29);
            this.dgwRandevuListe.MultiSelect = false;
            this.dgwRandevuListe.Name = "dgwRandevuListe";
            this.dgwRandevuListe.ReadOnly = true;
            this.dgwRandevuListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwRandevuListe.RowTemplate.Height = 25;
            this.dgwRandevuListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwRandevuListe.Size = new System.Drawing.Size(962, 530);
            this.dgwRandevuListe.TabIndex = 3;
            this.dgwRandevuListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRandevuListe_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 100);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(260, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Randevular Listesi";
            // 
            // BtnRandevuListesiGeri
            // 
            this.BtnRandevuListesiGeri.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRandevuListesiGeri.BackgroundImage = global::HastaneApp.Properties.Resources.back;
            this.BtnRandevuListesiGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRandevuListesiGeri.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRandevuListesiGeri.Location = new System.Drawing.Point(12, 677);
            this.BtnRandevuListesiGeri.Name = "BtnRandevuListesiGeri";
            this.BtnRandevuListesiGeri.Size = new System.Drawing.Size(60, 60);
            this.BtnRandevuListesiGeri.TabIndex = 19;
            this.BtnRandevuListesiGeri.UseVisualStyleBackColor = false;
            this.BtnRandevuListesiGeri.Click += new System.EventHandler(this.BtnRandevuListesiGeri_Click);
            // 
            // FrmRandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 749);
            this.Controls.Add(this.BtnRandevuListesiGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRandevuListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRandevuListe";
            this.Load += new System.EventHandler(this.FrmRandevuListe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgwRandevuListe;
        private Panel panel1;
        private Label label4;
        private Button BtnRandevuListesiGeri;
    }
}