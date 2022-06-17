using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Sql işlemlerimiz için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); //Bağlantı nesnemizi tanımladık.

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); //Datatable türünde dt nesnemizi tanımladık.
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());

            da.Fill(dt); // Tablomuza verilerimizi dataadapter nesnesi ile tanımladığımz da üzerinden aldık.
            dgwBrans.DataSource = dt; //Tablomuza gelen verileri dgwBrans'a aktardık.
            
        }

        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            //Brans Ekleme
            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("insert into  Tbl_Branslar (BransAd) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBrans.Text); //parametremizi form nesnemiz ile ilişkilendirdik.
            komut.ExecuteNonQuery(); //Komutumuzun sql tarafından çalıştırılmasını sağladık.
            bgl.baglanti().Close(); //Bağlantımızı kapatıyoruz.
            MessageBox.Show("Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); //Bildirimizi görüntüledik.
            FrmBrans_Load(sender, e); // dgw güncellemesi için formload çağırdık.

            //temizleme
            TxtBrans.Text = "";
            Txtid.Text = "";
        }

        private void dgwBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DgwBrans üzerinde seçilen satırın forma aktarılamsı

            int secilen = dgwBrans.SelectedCells[0].RowIndex; // Seçilen satırın index numarasını çektik.
            Txtid.Text = dgwBrans.Rows[secilen].Cells[0].Value.ToString(); //secilen index no'su ile de 0.sütun verisini çağırdık.
            TxtBrans.Text = dgwBrans.Rows[secilen].Cells[1].Value.ToString();  //secilen index no'su ile de 1.sütun verisini çağırdık.

        }

        private void BtnBransSil_Click(object sender, EventArgs e)
        {
            // Branş Silme
            //İd'ye göre sileceğimiz sorgumuzu yazdık.
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where Bransid=@b1",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",Txtid.Text); // Sileceğimiz id no'sunu txtid nesnesinden aldık.
            komut.ExecuteNonQuery(); // Komutumuzu sql tarafında çalıştırdık.
            bgl.baglanti().Close(); //Bağlantımızı kapattık.
            MessageBox.Show("Branş Silindi");
            FrmBrans_Load(sender, e); // dgw güncellemesi için formload çağırdık.
        }

        private void BtnBransGuncelle_Click(object sender, EventArgs e)
        {
            // Branş Güncelleme

            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar Set BransAd=@p1 Where Bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtBrans.Text); //parametremizi form nesnemiz ile ilişkilendirdik.
            komut.Parameters.AddWithValue("@p2", Txtid.Text); //parametremizi form nesnemiz ile ilişkilendirdik.
            komut.ExecuteNonQuery();  // Komutumuzu sql tarafında çalıştırdık.
            bgl.baglanti().Close();
            MessageBox.Show("Branş Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmBrans_Load(sender, e); // dgw güncellemesi için formload çağırdık.
        }

        private void BtnBransDuzenleGeri_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.Show();
            this.Close();
        }
    }
}
