using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Veritabanı işlemlerini yapabilmek için kütüphanemizi ekledik.

namespace HastaneApp
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc; //public olarak tanımladığımız tc değişkeni ile Hasta Giris Formu üzerindeki tc adersini Hasta Detay formuna çektik.

        SqlBaglanti bgl = new SqlBaglanti();

        private void veridoldur()
        {
            //Veri doldurmak için select sorgumuzu yazdık.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaSikayet From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt); //Datatabel'e sorgumuzdan gelen sonucu yazdırdık.
            dgwRandevuGecmisi.DataSource = dt;
            
        }

        private void aktifRandevuListeletme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevuid,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'" + " and RandevuDoktor='" + CmbDoktor.Text + "' and RandevuDurum=0 ", bgl.baglanti());
            da.Fill(dt);
            dgwAktifRandevu.DataSource = dt;
        }
        
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {

            //Ad Soyad Çekme

            LblTC.Text = tc; //tc değişkenine aktardığımız Hasta Giriş formundan gelen Hasta tc'sini LblTC'de gözükmesini sağladık.
            //Sorgumuzda hastamızın adını ve soyadını tc numarasına göre hasta detayının listelenmesini sağladık.
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] +" "+ dr[1]; //Ad ve Soyad'ı aralarında boşluk olacak şekilde lable'e atadık.
            }
            bgl.baglanti().Close();

            //Randevu Geçmiş DataGridview 
            // Yerine 
            veridoldur();


            //Branşları Çekme.
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb'den branşı seçilen doktorları listeleme

            CmbDoktor.Items.Clear(); //Doktorların bransları combobax a eklenince temizlenmesi
            CmbDoktor.Text = "";
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 =komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevuid,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "'"+ " and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0 ", bgl.baglanti());
            da.Fill(dt);
            dgwAktifRandevu.DataSource = dt;
        } 

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTC.Text; //Hasta detay formundaki hastanın tc nosunu hasta bilgilerini duzenle formuna gonderdik.
            fr.ShowDialog();

            //İtems temizleme
            CmbBrans.Items.Clear();
            CmbDoktor.Items.Clear();

            if (fr != null)
            {
                FrmHastaDetay_Load(sender, e); //Hasta Güncellemesi için.
            }
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            if (Txtid.Text != "")
            {
                veridoldur();
                CmbDoktor_SelectedIndexChanged(sender, e);
                // Randevu Alma işleminde aldığımız randevunun durumunu 1 yapıyoruz yani alınmış olarak gösterdik
                // ve alınan randevunun hangi hasta tarafından alındığını belirtiyoruz.
                // Sorgumuzu komutumuza aktarıyoruz.
                SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2 Where Randevuid=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", LblTC.Text); //Sisteme giriş yapan hastanın tc nosu.
                komut.Parameters.AddWithValue("@p2", RchSikayet.Text); //Sisteme randevu almak için giriş yapan hastanın şikayeti
                komut.Parameters.AddWithValue("@p3", Txtid.Text); // Güncelleme işlemi yapacağımız randevunun id nosunu çektik.
                komut.ExecuteNonQuery(); // Sorgumuzu sql tarafında çalıştırdık.

                bgl.baglanti().Close();
                MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veridoldur();
                aktifRandevuListeletme();
                //İşlem sonrası temizleme
                RchSikayet.Text = "";
                CmbBrans.Text = "";
                CmbDoktor.Text = "";
            }
            else
            {
                MessageBox.Show("Randevu Seçmediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //aktifRandevuListeletme(); // Dgv Aktif Randevular sıfırlamak için.

        }

        private void dgwAktifRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DgwAktifRandevu'dan seçilen satırın bilgilerini form nesnelerine aktardık.
            int secilen = dgwAktifRandevu.SelectedCells[0].RowIndex; // Seçili hücrenin index değerini aktardık.
            Txtid.Text = dgwAktifRandevu.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnHastaDetayGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Close();
        }
    }
}
