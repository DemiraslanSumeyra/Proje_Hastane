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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();  
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO dbo.Tbl_Branslar (BransAd) VALUES(@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",txt_brans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_brans.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM dbo.Tbl_Branslar WHERE BransID=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE dbo.Tbl_Branslar SET BransAd=@p1 WHERE BransID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_brans.Text);
            komut.Parameters.AddWithValue("@p2", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş güncellendi.");
        }
    }
}
