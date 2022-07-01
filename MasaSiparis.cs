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
    public partial class MasaSiparis : Form
    {
        public MasaSiparis()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        SqlDataAdapter komut;
        DataSet tablo_seti = new DataSet();
        DataSet tabloSetSiparisListe = new DataSet();


        public string kulid = "";

        public string MasaNo = "";

        string yemekId = "";
        string sepetid = "";
        

        public void yemekleriGetir(string kategori)
        {
            tablo_seti.Clear();
            string sql = "SELECT tblYemek.id,YemekAdi,YemekFiyat FROM tblYemek inner join tblYemekKategori on tblYemek.KatId=tblYemekKategori.id where KategoriAdi='" + kategori + "' ";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblYemek");

            baglanti.Close();
            gridControlYemek.DataSource = tablo_seti.Tables["tblYemek"];

        }
        void kategoriButonlarıGetir()
        {
            string[] kategoriText = { "Başlangıçlar", "Çorba ve Salatalar", "Ana Yemekler", "İçecekler", "Tatlılar" };
            baglanti.Open();
            string sql = "select * from tblYemekKategori ";
            komutlarim = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komutlarim.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Button btn = new Button();
                    btn.Text = Convert.ToString(dr["KategoriAdi"]);
                    btn.BackColor = Color.Brown;
                    btn.Font = new Font(btn.Font.FontFamily, 10, btn.Font.Style);
                    btn.Size = new Size(100, 60);
                    btn.Click += BtnKategoriler;
                    flwLytPnlKategoriler.Controls.Add(btn);

                }
            }
            baglanti.Close();

        }

        private void BtnKategoriler(object sender, EventArgs e)
        {
           

            yemekleriGetir(((Button)sender).Text);
        }

        public void MasalariGetir()
        {
            try
            {


                baglanti.Open();
                komutlarim = new SqlCommand("  select distinct tblMasaNumarasi.MasaNo,tblSiparis.MasaNo,tblMasaNumarasi.MasaDurum from tblMasaNumarasi left join tblSiparis on tblMasaNumarasi.id=tblSiparis.MasaNo ", baglanti);
                SqlDataReader dr = komutlarim.ExecuteReader();
                int btnbilgi = 0;
                for(int i = 0; i < 3; i++)
                {
                    Button btnBilgi = new Button();
                    btnBilgi.Size = new Size(100, 100);
                    
                    btnBilgi.Font = new Font("Georgia", 12, FontStyle.Bold);
                    if (btnbilgi == 0)
                    {
                        btnBilgi.Text = "Masa da Sipariş Var";

                        btnBilgi.BackColor = Color.DarkRed;
                    }
                    else if (btnbilgi == 1)
                    {
                        btnBilgi.Text = "Masa Boş" ;

                        btnBilgi.BackColor = Color.DarkGreen;
                    }
                    else if(btnbilgi == 2)
                    {
                        btnBilgi.Text = "Masa Siparişe Kapalı";

                        btnBilgi.BackColor = Color.DarkGray;
                    }
                    btnBilgi.ForeColor = Color.White;
                   
                    flowLytMasalarUstBilgi.Controls.Add(btnBilgi);
                    btnbilgi++;
                }
                
               
                

                while (dr.Read())
                {
                    Button btnMasa = new Button();
                    btnMasa.Text = dr[0].ToString();

                    btnMasa.Size = new Size(150, 150);
                    btnMasa.ForeColor = Color.White;
                    btnMasa.Font = new Font("Georgia", 20, FontStyle.Bold);
                    if (dr[2].ToString() == "True")
                    {
                        
                        if (dr[1].ToString() == "")
                        {

                            btnMasa.BackColor = Color.DarkGreen;
                        }
                        else
                        {

                            btnMasa.BackColor = Color.DarkRed;
                        }
                       
                        btnMasa.Click += BtnMasa_Click;

                        
                    }
                    else
                    {
                        btnMasa.BackColor = Color.DarkGray;
                        btnMasa.Enabled = false;
                    }
                    flowLytMasalar.Controls.Add(btnMasa);
                    



                }
                baglanti.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnMasa_Click(object sender, EventArgs e)
        {
            
            tableLayoutPanel1.Visible = false;
            tableSiparisBolumu.Visible = true;
            kategoriButonlarıGetir();
            lblMasa.Text = ((Button)sender).Text;
            siparisListesiGetir(((Button)sender).Text);
            MasaNo = ((Button)sender).Text;


        }
        public void yemekGetirBaslangic()
        {
            string sql = "SELECT tblYemek.id,YemekAdi,YemekFiyat FROM tblYemek inner join tblYemekKategori on tblYemek.KatId=tblYemekKategori.id where tblYemekKategori.id=1";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblYemek");

            baglanti.Close();
            gridControlYemek.DataSource = tablo_seti.Tables["tblYemek"];
        }
        
        private void MasaSiparis_Load(object sender, EventArgs e)
        {
            MasalariGetir();
            yemekGetirBaslangic();
        }

        
       
        public void siparisListesiGetir(string siparisId)
        {
            

            string sql = "SELECT tblSiparis.id,YemekAdi,UrunAdet,YemekFiyat FROM tblSiparis inner join tblYemek on tblSiparis.UrunId=tblYemek.id where MasaNo=" + Convert.ToInt32(siparisId) + " ";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tabloSetSiparisListe, "tblSiparis");

            baglanti.Close();
            gridControlSepet.DataSource = tabloSetSiparisListe.Tables["tblSiparis"];


        }



        private void gridViewYemek_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewYemek.GetDataRow(gridViewYemek.FocusedRowHandle);

            if (dr != null)
            {
                yemekId = dr[0].ToString();
                txtUrunAdi.Text = dr[1].ToString();
            }
        }

        private void dgvSepetTablosu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drw = dgvSepetTablosu.GetDataRow(dgvSepetTablosu.FocusedRowHandle);
            if (drw != null)
            {
                sepetid = drw[0].ToString();
                txtSepet.Text = drw[1].ToString();
                cmbxSepet.Text = drw[2].ToString();

            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "")
            {
                MessageBox.Show(" Lütfen hangi yemeği ekleyeceğinizi seçiniz !", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (cmbxAdet.SelectedIndex != -1)
                {
                    DateTime today = DateTime.Now;

                    baglanti.Open();
                    SqlCommand komutlarim = new SqlCommand("insert into tblSiparis(UrunAdet,UrunId,MasaNo,SiparisTarihi,SiparisGuncellemeTarihi) values(@adet,@urunid,@masano,@bugununTarihi,@guncellemeTarihi) ", baglanti);
                    komutlarim.Parameters.AddWithValue("@adet", cmbxAdet.Text);
                    komutlarim.Parameters.AddWithValue("@urunid", Convert.ToInt32(yemekId));
                    komutlarim.Parameters.AddWithValue("@masano", Convert.ToInt32(MasaNo));
                    komutlarim.Parameters.AddWithValue("@bugununTarihi", Convert.ToDateTime(today.ToString()));
                    komutlarim.Parameters.AddWithValue("@guncellemeTarihi", Convert.ToDateTime(today.ToString()));
                    komutlarim.ExecuteNonQuery();
                    baglanti.Close();
                    tabloSetSiparisListe.Tables.Clear();
                    siparisListesiGetir(MasaNo);
                    txtUrunAdi.Text = "";
                    cmbxAdet.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Lütfen  kaç adet sipariş edeceğinizi seçiniz !", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbxSepet.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Siparişi güncellemek istediğinizden emin misiniz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    komutlarim = new SqlCommand("update tblSiparis set UrunAdet=@adet,SiparisGuncellemeTarihi=GETDATE() where id=@id  ", baglanti);
                    komutlarim.Parameters.AddWithValue("@adet", cmbxSepet.Text);

                    komutlarim.Parameters.AddWithValue("@id", sepetid);
                    komutlarim.ExecuteNonQuery();
                    baglanti.Close();
                    tabloSetSiparisListe.Tables.Clear();
                    siparisListesiGetir(MasaNo);
                    txtSepet.Text = "";
                    cmbxSepet.SelectedIndex = -1;
                }


            }
            else
            {
                MessageBox.Show("Lütfen  hangi siparişi güncelleyeceğinizi seçiniz !", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (cmbxSepet.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Siparişi iptal etmek istediğinizden emin misiniz ?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    komutlarim = new SqlCommand("delete from tblSiparis where id=@id  ", baglanti);


                    komutlarim.Parameters.AddWithValue("@id", sepetid);
                    komutlarim.ExecuteNonQuery();
                    baglanti.Close();
                    tabloSetSiparisListe.Tables.Clear();
                    siparisListesiGetir(MasaNo);
                    txtSepet.Text = "";
                    cmbxSepet.SelectedIndex = -1;
                }


            }
            else
            {
                MessageBox.Show("Lütfen iptal edeceğiniz siparişi seçiniz !", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
