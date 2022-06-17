using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Veritabanı işlemleri için kütüphanemizi ekledik.

namespace HastaneApp
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); // Sql baglantı nesnemizi sqlBaglanti ile ilişkilendirdik.
        
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",bgl.baglanti());
           
            //Parametrelerimizi form nesnelerimizle ilişkilendirdik.
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            
            //komutumuzu(sorgumuzu) okuması için sql tarafına gönderdik.
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) //Eğer girdiğimiz veriler doğru ise SekreterDetay formunu ekrana getirmesini istedik.
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.Tcnumara = MskTC.Text; // Sekreter Detay formunda görüntüleyebilmek için SekreterDetay formundaki Tcnumara değişkenine aktardık.

                frs.Show();
                this.Close();
            }
            else //Eğer girilen Tc veya sifre hatalı ise
            {
                MessageBox.Show("Hatalı Tc Veya Şifre Girdiniz !");
            }
            bgl.baglanti().Close(); //İşlemimiz bittikten sonra sql bağlantımızı kapattık.
        }

        private void BtnSekreterGirisGeri_Click(object sender, EventArgs e)
        {
            this.Close(); // Ekrandaki formu kapadık.
            FrmGirisler frg = new FrmGirisler();
            frg.Show();
        }
    }
}
