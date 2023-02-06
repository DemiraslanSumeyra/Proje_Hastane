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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msk_TC.Text = TCNO;

            SqlCommand komut = new SqlCommand("select * from dbo.Tbl_Doktorlar WHERE DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                cmb_brans.Text = dr[3].ToString();
                txt_sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE dbo.Tbl_Doktorlar SET DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 WHERE DoktorTC=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p5", msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt güncellendi.");
        }
    }
}
