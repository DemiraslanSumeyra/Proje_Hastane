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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM dbo.Tbl_Doktorlar WHERE DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Tbl_Randevular WHERE RandevuDoktor='"+lbl_adsoyad.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_bilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = lbl_TC.Text;
            fr.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rch_sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
