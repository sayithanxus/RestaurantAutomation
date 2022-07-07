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
    public partial class frmDetayliUrunAnalizi : Form
    {
        public frmDetayliUrunAnalizi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        SqlDataAdapter komut;
        DataSet tablo_seti = new DataSet();

        private void frmDetayliUrunAnalizi_Load(object sender, EventArgs e)
        {
            tablo_seti.Clear();
            string sql = "select sum(HesapTutari) 'TOPLAM CİRO',convert(varchar, SiparisTarihi, 23) AS 'GÜN' from tblGecmisSiparisler group by convert(varchar, SiparisTarihi, 23)  ";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblGecmisSiparisler");

            baglanti.Close();
            gridControlDtyliUrunAnlz.DataSource = tablo_seti.Tables["tblGecmisSiparisler"];

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            tablo_seti.Clear();
            string sql = "select sum(HesapTutari) 'TOPLAM CİRO',convert(varchar, SiparisTarihi, 23) AS 'GÜN' from tblGecmisSiparisler where convert(varchar,convert(date,SiparisTarihi),105)>'" + dTpckrIlkTarih.Value.ToShortDateString().Replace(".", "-") + "' and convert(varchar,convert(date,SiparisTarihi),105)<'" + dTpckrSon.Value.ToShortDateString().Replace(".", "-") + "'  group by convert(varchar, SiparisTarihi, 23) ";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblGecmisSiparisler");

            baglanti.Close();
            gridControlDtyliUrunAnlz.DataSource = tablo_seti.Tables["tblGecmisSiparisler"];
        }
    }

}
