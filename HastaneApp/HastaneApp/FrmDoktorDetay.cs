using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL işlemlerimiz için kütüphanemizi çağırdık.

namespace HastaneApp
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); // bağlantı nesnemizi tanımladık.
        public string TC; // Tc adersini DoktorGiris formundan çekmek için değişkenimizi tanımladık.
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;
            // Doktor Ad Soyad
            // komut nesnemize sorgumuzu aktardık.
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", LblTC.Text); // LblTc'den gelen değeri p1 parametremize gönderdik.
            SqlDataReader dr = komut.ExecuteReader(); // Komutumuzu okumasını sağlıyoruz.

            while (dr.Read()) // Okunan değer için aşağıdaki işlemi uyguluyoruz.
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];   //0.Sütun(Adı) ve 1.Sütunda yer alan soyadı bilgisini birleştirerek lblAdSoyad'a aktarıyoruz.
            }
            bgl.baglanti().Close(); // Bağlantımızı kapattık.



            // Randevular
            DataTable dt = new DataTable(); // DataTable türünde dt nesnemizi tanımladık.
            // Randevu Doktoru bizim randevu doktorumuza eşit olan kayıtların sorgusunu yazdık.
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuDurum,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaSikayet,HastaTC From Tbl_Randevular Where DoktorTC='" +LblTC.Text + "'", bgl.baglanti());
            da.Fill(dt); // da ile dt nesnemize verileri aktardık.
            dgwRandevuListesi.DataSource = dt; // dt'den gelen verileri dgwRandevuListesi'ne aktardık.
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = LblTC.Text; // LblTC'den gelen DoktorTc no'sunu DoktorBİlgiDüzenleme formuna çekmek için TCNO değişkenine aktardık.
            fr.ShowDialog();
            if (fr != null)
            {
                FrmDoktorDetay_Load(sender, e); // Doktor bilgisi güncellemek için.
            }
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.ShowDialog(); // Duyurular formunu gösterdik.
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programdan çıkış yaptırdık.
        }

        private void dgwRandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgwRandevuListesi.SelectedCells[0].RowIndex; // DgwRandevuListesi'nden seçilen hücrenin index numarasını değişkenimize aktardık.
            RchSikayet.Text = dgwRandevuListesi.Rows[secilen].Cells[5].Value.ToString(); // 7.Sütunda bulunan HastaSikayet verisini aktardık.


        }

        private void BtnDoktorDetayGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Close();
        }
    }
}
