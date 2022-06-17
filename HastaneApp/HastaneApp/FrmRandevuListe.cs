using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Sql işlemleri için kütüphanemizi ekledik.

namespace HastaneApp
{
    public partial class FrmRandevuListe : Form
    {
        public FrmRandevuListe()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); //Bağlantı nesnemizi tanımladık.
        private void FrmRandevuListe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // DataTable türünde dt nesnemizi tanımladık.
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuDurum,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaSikayet,HastaTC From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt); //sorgumuzdan gelen verilerimizi dt nesnemize gönderdik.
            dgwRandevuListe.DataSource = dt; // dt'ye akatardığımız verilerimizi dgw'de listelenmesini sağlıyoruz.
            
        }
        private void dgwRandevuListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRandevuListesiGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
