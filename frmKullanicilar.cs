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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        SqlDataAdapter komut;
        DataSet tablo_seti = new DataSet();

        public void KullanicilariGetir()
        {
            tablo_seti.Clear();
            baglanti.Open();
            string sql = "SELECT * from tblKullanici ";
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblKullanici");
            baglanti.Close();
            gridControlKullanici.DataSource = tablo_seti.Tables["tblKullanici"];
        }
        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            KullanicilariGetir();

        }
        public string kulid = "";
        private void gridKullanicilar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridKullanicilar.GetDataRow(gridKullanicilar.FocusedRowHandle);
            if (dr != null)
            {
                kulid = dr[0].ToString();
                txtKulAd.Text = dr[1].ToString();
                txtSifre.Text = dr[2].ToString();
                txtAd.Text = dr[3].ToString();
                txtSoyad.Text = dr[4].ToString();
            }

            

        }
        void temizle()
        {
            txtAd.Text = "";
            txtKulAd.Text = "";
            txtSifre.Text = "";
            txtSoyad.Text = "";

        }
        KullaniciVarYok kul;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int kulVar = 0;
            if (txtAd.Text != "" && txtKulAd.Text != "" && txtSifre.Text != "" && txtSoyad.Text != "")
            {
                 kul = new KullaniciVarYok();
                kulVar = kul.KullaniciKontrol("SELECT * FROM tblKullanici where KulAdi='"+txtKulAd.Text+"'", kulid);
                if (kulVar == 0)
                {
                    if (txtSifre.Text.Length>7 )
                    {
                        baglanti.Open();
                        komutlarim = new SqlCommand("insert into tblKullanici(KulAdi,KulSifre,Adi,Soyadi) values(@kuladi,@kulsifre,@ad,@soyad)", baglanti);
                        komutlarim.Parameters.AddWithValue("@kuladi", txtKulAd.Text);
                        komutlarim.Parameters.AddWithValue("@kulsifre", txtSifre.Text);
                        komutlarim.Parameters.AddWithValue("@ad", txtAd.Text);
                        komutlarim.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        komutlarim.ExecuteNonQuery();
                        baglanti.Close();
                        tablo_seti.Clear();
                        KullanicilariGetir();
                       
                        MessageBox.Show(txtAd.Text+" "+txtSoyad.Text+" "+"Başarıyla Eklendi ", "Kayıt İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Şifre Uzunluğunu 7 Karakterden fazla giriniz !", "Kayıt İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (kulVar != 0)
                {
                    MessageBox.Show("Böyle bir kullanici var !", "Kayıt İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !", "Kayıt İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(kulid) != 0)
            {

                if (txtAd.Text != "" && txtKulAd.Text != "" && txtSifre.Text != "" && txtSoyad.Text != "")
                {
                    
                    
                        if (txtSifre.Text.Length > 7)
                        {
                        DialogResult dialog = MessageBox.Show("Güncellemek İstediğinizden Emin misiniz ?", "Güncelleme İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            baglanti.Open();
                            komutlarim = new SqlCommand("update tblKullanici set KulAdi=@kuladi,KulSifre=@kulsifre,Adi=@ad,Soyadi=@soyad where id=" + Convert.ToInt32(kulid) + "", baglanti);
                            komutlarim.Parameters.AddWithValue("@kuladi", txtKulAd.Text);
                            komutlarim.Parameters.AddWithValue("@kulsifre", txtSifre.Text);
                            komutlarim.Parameters.AddWithValue("@ad", txtAd.Text);
                            komutlarim.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                            komutlarim.ExecuteNonQuery();
                            baglanti.Close();
                            tablo_seti.Clear();
                            KullanicilariGetir();
                            temizle();
                            MessageBox.Show("Başarıyla Güncellendi", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifre Uzunluğunu 7 Karakterden fazla giriniz !", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                   
                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tablodan Bir Kullanici Seçiniz !", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(kulid) != 0)
            {

                DialogResult dialog = MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "Silme İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    komutlarim = new SqlCommand("delete from tblKullanici where id=" + Convert.ToInt32(kulid) + "", baglanti);

                    komutlarim.ExecuteNonQuery();
                    baglanti.Close();
                    tablo_seti.Clear();
                    KullanicilariGetir();
                    temizle();
                    MessageBox.Show("Başarıyla Silindi", "Silme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }




            }
            else
            {
                MessageBox.Show("Lütfen Tablodan Bir Kullanici Seçiniz !", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
    }
}
