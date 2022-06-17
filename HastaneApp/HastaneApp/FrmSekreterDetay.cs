using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql işlemlerimiz için kütüphanemizi çağırdık. 

namespace HastaneApp
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string Tcnumara; // Sekreter Giris formundan aldığımız Tc no'sunu aktarıyoruz.
        public string DoktorTC;
        SqlBaglanti bgl = new SqlBaglanti(); // Sql baglantı nesnemizi sqlBaglanti ile ilişkilendirdik.

        // BransCagirma
        private void branscagir()
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

        // Brans ve Doktorlar dgv cagirma
        private void bransvedoktordgvgetir()
        {
            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable(); //DataTable türünde dt1 nesnemizi oluşturduk.
            //DataAdapter nesnemiz ile sorgumuzu DataAdapter türünden ürettiğimiz da değişkenine aktardık.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1); //DataAdapter tarafından tanımladığımız da değişkenine Sorgumuzu aktarmıştık sorgu sonucumuzu dt1 nesnemize aktarıyoruz.
            dgwBranslar.DataSource = dt1; //dt1'e aktardığımız sanal tablo verisini datagridview'imizde görüntülenmesi işin aktarma işlemini yaptık.


            //Doktorları listeleme
            DataTable dt2 = new DataTable(); //DataTable türünde dt2 nesnemizi oluşturduk.
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' '+ DoktorSoyad) as Doktorlar, DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);//DataAdapter tarafından tanımladığımız da2 değişkenine Sorgumuzu aktarmıştık sorgu sonucumuzu dt2 nesnemize aktarıyoruz.
            dgwDoktorlar.DataSource = dt2; //dt2'ye aktardığımız sanal tablo verisini datagridview'imizde görüntülenmesi işin aktarma işlemini yaptık.
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = Tcnumara; // Giris Formundan gelen tc numarasını aktardık.
            //AdSoyad Bilgisi

            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text); //LblTC'den aldığımız tc'yi parametreye bağladık ve sorgumuzda kullandık.
            SqlDataReader dr1 = komut1.ExecuteReader();  //komutumuzu(sorgumuzu) okuması için sql tarafına gönderdik.
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString(); //Sorgudan gelen değeri LblAdSoyad'a aktardık.
            }
            bgl.baglanti().Close(); // İşlemimiz bittikten sonra sql bağlantımızı kapattık.


            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable(); //DataTable türünde dt1 nesnemizi oluşturduk.
            //DataAdapter nesnemiz ile sorgumuzu DataAdapter türünden ürettiğimiz da değişkenine aktardık.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1); //DataAdapter tarafından tanımladığımız da değişkenine Sorgumuzu aktarmıştık sorgu sonucumuzu dt1 nesnemize aktarıyoruz.
            dgwBranslar.DataSource = dt1; //dt1'e aktardığımız sanal tablo verisini datagridview'imizde görüntülenmesi işin aktarma işlemini yaptık.


            //Doktorları listeleme
            DataTable dt2 = new DataTable(); //DataTable türünde dt2 nesnemizi oluşturduk.
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' '+ DoktorSoyad) as Doktorlar, DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);//DataAdapter tarafından tanımladığımız da2 değişkenine Sorgumuzu aktarmıştık sorgu sonucumuzu dt2 nesnemize aktarıyoruz.
            dgwDoktorlar.DataSource = dt2; //dt2'ye aktardığımız sanal tablo verisini datagridview'imizde görüntülenmesi işin aktarma işlemini yaptık.


            //Branşı combobax'a aktarma

            branscagir();
        }

        private void BtnRandevuKaydet_Click(object sender, EventArgs e)

        { 
            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,DoktorTC) values(@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());
            SqlCommand komut2 = new SqlCommand("select DoktorTC From Tbl_Doktorlar Where DoktorAd +' '+ DoktorSoyad = '"+CmbDoktor.Text+"'",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();  //komutumuzu(sorgumuzu) okuması için sql tarafına gönderdik.
            while (dr2.Read())
            {
                LblDoktorTC.Text = dr2[0].ToString(); //Sorgudan gelen degeri
            }
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text); //Parametrelerimizi form nesnelerimiz ile ilişkilendirdik.
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.Parameters.AddWithValue("@r5", LblDoktorTC.Text);
            komutkaydet.ExecuteNonQuery(); //İnsert komutunun sql tarafında çalıştırılması için executeNonQuery komutunu çalıştırdık.
            bgl.baglanti().Close();  // İşlemimiz bittikten sonra sql bağlantımızı kapattık.
            MessageBox.Show("Randevu Oluşturuldu");

            CmbBrans_SelectedIndexChanged(sender, e);

            
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            CmbDoktor.Text = "";

            //Sorgumuzu komut nesnemiz gönderdik.
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text); //Parametrelerimizi form nesnelerimiz ile ilişkilendirdik.
            SqlDataReader dr = komut.ExecuteReader(); //komutumuzu(sorgumuzu) okuması için sql tarafına gönderdik.

            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close(); // İşlemimiz bittikten sonra sql bağlantımızı kapattık.
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.ShowDialog(); //DoktorGiris formunu çağırdık.
            if (drp != null)
            {
                CmbBrans.Items.Clear();
                branscagir();
                bransvedoktordgvgetir();
            }
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.ShowDialog(); //Brans Panelini çağırdık.
            if (frb != null)
            {
                CmbBrans.Items.Clear();
                branscagir();
                bransvedoktordgvgetir();
            }
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListe frl = new FrmRandevuListe();
            frl.ShowDialog(); // RandevuListe formunu çağırdık.
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            //Sorgumuzu komut nesnemiSz gönderdik.
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text); //Parametremiz ile form nesnemizi ilişkilendirdik.
            komut.ExecuteNonQuery(); // Komutumuzu sql tarafında çalıştırılmasını sağladık.
            bgl.baglanti().Close(); // Bağlantımızı kapattık.
            MessageBox.Show("Duyuru Oluşturuldu");
            RchDuyuru.Text = "";
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.ShowDialog();
        }

        private void BtnSekreterDetayGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
