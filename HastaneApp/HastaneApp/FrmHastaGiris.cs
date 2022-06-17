using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Veritabanı komutlarını çalıştırabilmemiz için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();


        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit(); // Hasta Kayıt Ekranını çağırdık.
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //komut değişkenine sorgumuzu gönderdik
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text); //belirlediğimiz parametrelere textboxlarımızdan değerleri aktardık.
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader(); //Sql üzerinde komut değişkenimiz ile sorgumuzu ilettik ve okumasını sağladık.
            if (dr.Read()) //Eğer Tc ve Sifre doğru ise HastaDetay Formunu görüntülemesini sağladık.
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskTC.Text;
                fr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girdiniz.!");
            }
            bgl.baglanti().Close();

        }

        private void BtnHastaGirisGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frgiris = new FrmGirisler();
            frgiris.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
