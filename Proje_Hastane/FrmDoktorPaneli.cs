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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM dbo.Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO dbo.Tbl_Doktorlar  (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@d4",msk_TC.Text);
            komut.Parameters.AddWithValue("@d5",txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_TC.Text=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM dbo.Tbl_Doktorlar WHERE DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE dbo.Tbl_Doktorlar SET DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 WHERE DOktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@d4", msk_TC.Text);
            komut.Parameters.AddWithValue("@d5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
