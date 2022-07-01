using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komut;
        public static string kulid = "";

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kulAdi = txtkadi.Text;
            komut = new SqlCommand();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * from tblKullanici where KulAdi=@kadi AND KulSifre=@sifre";
            komut.Parameters.AddWithValue("@kadi", kulAdi);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();


            if (dr.Read())
            {

                this.Hide();



                AnaForm anasayfa = new AnaForm();

                anasayfa.Show();
            }



            else
            {

                MessageBox.Show("Böyle bir kullanıcı yok", "Giriş Yapma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }

        private void chckbxSifreKontrol_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxSifreKontrol.Checked == true)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
