using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL işlemleri için kütüphanemizi ekledik.

namespace HastaneApp
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); // Bağlantı nesnemizi tanımladık.
        public string TCNO; // DoktorDetayFormundan gelen DoktorTc verisini Doktor Bilgi Düzenle formuna çekmek için public değişken tanımladık.

        //Branşlar
        private void branslarcagir() 
        {
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
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            branslarcagir();
            MskTC.Text = TCNO; //DoktorDetayFormundan gelen DoktorTc adresini DoktorBilgiDuzenle formundaki MskTC adresine aktardık.

            // Sorgumuzu komut değişkenimize aktardık.
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text); // Formnesnemizi parametremiz ile ilişkilendirdik.
            SqlDataReader dr = komut.ExecuteReader(); //Sorgumuzun sql tarafında okunmasını sağladık.
            while (dr.Read())// Okunan verileri
            {
                TxtAd.Text = dr[1].ToString(); //1.Sütundaki DoktorAdı Textbox nesnemize aktardık.
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close(); // Bağlantımızı kapattık.
        }
        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            // Doktor Bilgilerini Güncelleme

            // Sorgumuzu komut değişkenimize aktardık.
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", MskTC.Text);
            komut2.ExecuteNonQuery(); // Sql tarafında çalıştırılmasını sağlıyoruz.,
            bgl.baglanti().Close(); // Bağlantımızı kapattık.
            MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBilgiGuncelle_Click_1(object sender, EventArgs e)
        {
            // Doktor Bilgilerini Güncelleme

            // Sorgumuzu komut değişkenimize aktardık.
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            SqlCommand komut3 = new SqlCommand("Update Tbl_Randevular set RandevuDoktor='"+TxtAd.Text+' '+TxtSoyad.Text+"' where DoktorTC=@p5",bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", MskTC.Text);
            komut3.Parameters.AddWithValue("@p5", MskTC.Text);
            komut2.ExecuteNonQuery(); // Sql tarafında çalıştırılmasını sağlıyoruz.
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close(); // Bağlantımızı kapattık.
            MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDoktorBilgiGuncelleGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
