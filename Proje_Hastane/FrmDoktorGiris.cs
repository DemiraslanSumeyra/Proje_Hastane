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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM dbo.Tbl_Doktorlar WHERE DoktorTC=@p1 AND DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
