using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //sql işlemlerimiz için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl =  new SqlBaglanti(); //baglantı nesnemizi tanımladık.
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable(); //DataTable türünde dt2 nesnemizi oluşturduk.
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);//DataAdapter tarafından tanımladığımız da1 değişkenine Sorgumuzu aktarmıştık sorgu sonucumuzu dt1 nesnemize aktarıyoruz.
            dgwDoktorPanel.DataSource = dt1; //dt1'ye aktardığımız sanal tablo verisini datagridview'imizde görüntülenmesi işin aktarma işlemini yaptık.


            //Branşı combobax'a aktarma

            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader(); //komutumuzu(sorgumuzu) okuması için sql tarafına gönderdik.

            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDoktorEkle_Click(object sender, EventArgs e)
        {
            // Doktor Ekleme
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) Values(@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text); //Parametrelerimizi form nesnelerimizle ilişkilendirdik.
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery(); // Komutumuzun sql tarafında çalıştırılmasını sağladık.
            bgl.baglanti().Close(); //İşimiz bittikten sonra bağlantımızı kapattık.

            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); //Bildiri mesajımız.

            //dgw güncelleme
            FrmDoktorPaneli_Load(sender, e); // dgw güncellenmesi için formload çağırdık.
        }

        private void dgwDoktorPanel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridview'imizde seçili olan satırın form'a aktardık.

            int secilen = dgwDoktorPanel.SelectedCells[0].RowIndex; //Hücrenin 0.Sütunundaki satır indexini aktardık.
            TxtAd.Text = dgwDoktorPanel.Rows[secilen].Cells[1].Value.ToString(); //Seçilen satır no'dan 1.sütunu yani Ad kısmını aktardık.
            TxtSoyad.Text = dgwDoktorPanel.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dgwDoktorPanel.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dgwDoktorPanel.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dgwDoktorPanel.Rows[secilen].Cells[5].Value.ToString();


        }

        private void BtnDoktorSil_Click(object sender, EventArgs e)
        {
            //Doktor Silme işlemi

            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text); //Parametremizi form nesnemiz ile ilişkilendirdik.
            komut.ExecuteNonQuery(); // Komutumuzu(sorgumuzu) sql tarafında çalıştırılmasını sağladık.
            bgl.baglanti().Close();  //Bağlantımızı kapattık.
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //Ekrana bildiri gelmesini sağladık.
            
            //dgw güncelleme
            FrmDoktorPaneli_Load(sender, e); // dgw güncellenmesi için formload çağırdık.
        }

        private void BtnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            // Doktor Bilgisi Güncelleme


            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", TxtAd.Text); //Parametrelerimizi form nesnelerimizle ilişkilendirdik.
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery(); // Komutumuzun sql tarafında çalıştırılmasını sağladık.
            bgl.baglanti().Close(); //İşimiz bittikten sonra bağlantımızı kapattık.

            MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dgw güncelleme
            FrmDoktorPaneli_Load(sender, e); // dgw güncellenmesi için formload çağırdık.
        }

        private void BtnDoktorBilgileriGeri_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay st = new FrmSekreterDetay();
            st.Show();
            this.Close();
        }
    }
}
