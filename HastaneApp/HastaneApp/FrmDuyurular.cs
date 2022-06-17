using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // sql işlemlerimiz için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); //sqlbaglanti nesnemizi tanımladık.

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // DataTable türünde dt nesnemizi tanımladık.
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            da.Fill(dt); // Verilerimizi dt nesnemize aktardık.
            dgwDuyurular.DataSource = dt; // dt nesnemizdeki verileri dgwDuyurular'a aktardık.
        }

        private void BtnDuyurularGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDuyuruSil_Click(object sender, EventArgs e)
        {
            // Duyuru Silme
            //İd'ye göre sileceğimiz sorgumuzu yazdık.
            SqlCommand komut = new SqlCommand("Delete From Tbl_Duyurular where Duyuruid=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", LblDuyuruid.Text); // Sileceğimiz id no'sunu lblduyuruid nesnesinden aldık.
            komut.ExecuteNonQuery(); // Komutumuzu sql tarafında çalıştırdık.
            bgl.baglanti().Close(); //Bağlantımızı kapattık.
            MessageBox.Show("Duyuru Silindi");
            FrmDuyurular_Load(sender, e); // dgw güncellemesi için formload çağırdık.
            this.Close();
        }

        private void dgwDuyurular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenid = dgwDuyurular.SelectedCells[0].RowIndex; //Hücrenin 0.Sütunundaki satır indexini aktardık.
            LblDuyuruid.Text = dgwDuyurular.Rows[secilenid].Cells[0].Value.ToString(); //Seçilen satır no'dan 1.sütunu yani Ad kısmını aktardık.
        }
    }
}
