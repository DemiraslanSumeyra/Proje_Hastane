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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = tc;
            //Ad soyad çekme
            SqlCommand komut = new SqlCommand("SELECT HastaAd,HastaSoyad FROM dbo.Tbl_Hastalar WHERE HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Randevular WHERE HastaTC=" +tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları çekme
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM dbo.Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM dbo.Tbl_Doktorlar WHERE DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Randevular WHERE RandevuBrans='"+ cmb_brans.Text+"' "+ " and RandevuDoktor='"+cmb_doktor.Text +"' and RandevuDurum=0" ,bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnk_bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCNo=lbl_TC.Text;
            fr.Show();
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE dbo.Tbl_Randevular SET RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 WHERE RandevuID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            komut.Parameters.AddWithValue("@p2",rch_sikayet.Text);
            komut.Parameters.AddWithValue("@p3", txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
