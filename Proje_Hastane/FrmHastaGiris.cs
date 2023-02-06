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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void lnk_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM dbo.Tbl_Hastalar WHERE HastaTC=@p1 AND HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
