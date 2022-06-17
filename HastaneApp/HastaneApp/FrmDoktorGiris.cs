using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL işlemleri için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); // bağlantı nesnemizi tanımladık.

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Sorgumuzu komutumuza aktarıyoruz.
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text); // Parametreleri form nesneleri ile ilişkilendirdik.
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) // Eğer okunan veriler veritabanındaki verilerle eşleşiyorsa.
            {
                //Eğer giriş başarılı ise DoktorDetay formunu gösterdik.
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = MskTC.Text; // DoktorDetay formunda gözükmesi için tc adresini TC değişkenine aktardık.
                fr.Show(); 
                this.Close();
            }
            else // Eğer hatalı ise uyarı mesajı vermesini sağladık.
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close(); // Bağlantımızı kapattık.
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Close();
        }
    }
}
