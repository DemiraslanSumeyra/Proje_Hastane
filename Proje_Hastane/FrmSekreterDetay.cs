using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNumara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbl_sekreterTC.Text = TCNumara;

            //Ad soyad 
            SqlCommand komut = new SqlCommand("SELECT SekreterAdSoyad FROM dbo.Tbl_Sekreterler WHERE SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_sekreterTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları dataGridViewa aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları dataGridViewa aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoktorAd + ' ' +DoktorSoyad) as 'Doktorlar' ,DoktorBrans FROM dbo.Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM dbo.Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("INSERT INTO dbo.Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) VALUES (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", msk_tarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", msk_saat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komutKaydet.Parameters.AddWithValue("@r4",cmb_doktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.");
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM dbo.Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_duyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) VALUES (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rch_duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void btn_doktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void btn_branspanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
