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
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
       
        MasaSiparis masa;
        DateTime tarihNow = DateTime.Now;
        private void btnMasaSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            masa = new MasaSiparis();
            
                masa.MdiParent = this;
                masa.Show();
            

        }

        
        frmMasaListele masaListele;
        private void btnMasaDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            masaListele = new frmMasaListele();
                masaListele.MdiParent= this;
                masaListele.Show();                
            
        }
        
       

        frmBelliTarihCiro frmBelliTarih;
        private void btnBelliTarihteCiro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmBelliTarih = new frmBelliTarihCiro();
            frmBelliTarih.MdiParent = this;
            frmBelliTarih.Show();
        }
        frmOdeme frmOdeme;
        private void btnOdemeMasaSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmOdeme = new frmOdeme();
            frmOdeme.MdiParent = this;
            frmOdeme.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Close();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.MdiParent = this;
            anaSayfa.Show();
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.MdiParent = this;
            anaSayfa.Show();
        }

        private void btnMevcutKullanicilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmKullanicilar kullanicilar = new frmKullanicilar();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmGiris giris = new frmGiris();
            giris.Show();
        }
        frmDetayliUrunAnalizi detayliUrunAnalizi;
        private void btnDetayliUrunAnalizRaporu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            detayliUrunAnalizi = new frmDetayliUrunAnalizi();
            detayliUrunAnalizi.MdiParent = this;
            detayliUrunAnalizi.Show();
        }
    }
}
