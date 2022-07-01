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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT * from tblGecmisSiparisler ", baglanti);
            SqlDataReader dr = command.ExecuteReader();
            int toplam = 0;
            int cik = 0;
            while (dr.Read())
            {

                chartControlSon20Siparis.Series["Son 20 Sipariş"].Points.AddPoint(Convert.ToDateTime(dr["SiparisTarihi"]), Convert.ToInt32(dr["HesapTutari"]));
                if (cik == 20)
                {
                    break;
                }
                cik++;
            }



            baglanti.Close();
        }
    }
}
