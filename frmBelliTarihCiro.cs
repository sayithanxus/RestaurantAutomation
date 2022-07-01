using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmBelliTarihCiro : Form
    {

        public frmBelliTarihCiro()
        {
            InitializeComponent();
        }
        gunSonuHesap gsh = new gunSonuHesap();
        DateTime tarihNow = DateTime.Now;
        public void chartTemizle()
        {
            foreach (var chrt in chrtKarHesaplayici.Series)
            {
                chrt.Points.Clear();
            }
        }

        

        private void frmBelliTarihCiro_Load(object sender, EventArgs e)
        {
            int toplamFiyat = gsh.HesapToplami("SELECT * from tblGecmisSiparisler where convert(date,SiparisTarihi)=convert(date,'" + tarihNow.ToString("u") + "') ");
            if (toplamFiyat == 0)
            {
                chrtKarHesaplayici.Series["Gun Sonu"].Points.AddXY(tarihNow, 0);
               
            }
            else
            {
                chrtKarHesaplayici.Series["Gun Sonu"].Points.AddXY(tarihNow, toplamFiyat);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            chartTemizle();

            int toplamFiyat = gsh.BelliTarihHesapToplami("SELECT * FROM tblGecmisSiparisler where  convert(varchar,convert(date,SiparisTarihi),105)='" + dtmpckrDate.Value.ToShortDateString().Replace(".", "-") + "' ");
            if (toplamFiyat == 0)
            {
                chrtKarHesaplayici.Series["Gun Sonu"].Points.AddXY(dtmpckrDate.Value.ToShortDateString(), 0);


            }
            else
            {

                chrtKarHesaplayici.Series["Gun Sonu"].Points.AddXY(dtmpckrDate.Value.ToShortDateString(), toplamFiyat);
            }
        }
    }
}
