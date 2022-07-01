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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        SqlDataAdapter komut;
        DataSet tablo_seti = new DataSet();
        public string masaNo="";
        public int toplamFiyat = 0;
        public void siparisListesiGetir(string masaNo)
        {

            tablo_seti.Clear();
            string sql = "SELECT MasaNo,YemekAdi,UrunAdet,YemekFiyat FROM tblSiparis inner join tblYemek on tblSiparis.UrunId=tblYemek.id where MasaNo=" + Convert.ToInt32(masaNo) + " ";
            baglanti.Open();
            komut = new SqlDataAdapter(sql, baglanti);
            komut.Fill(tablo_seti, "tblSiparis");

            baglanti.Close();
            grdControlOdeme.DataSource = tablo_seti.Tables["tblSiparis"];


        }
        public void HesapTutar()
        {
            baglanti.Open();
            komutlarim = new SqlCommand();
            komutlarim.Connection = baglanti;
            komutlarim.CommandText = "SELECT *from tblSiparis  where MasaNo=@masano ";
            komutlarim.Parameters.AddWithValue("@masano", masaNo);



            SqlDataReader dr = komutlarim.ExecuteReader();
            
            if (dr.HasRows)
            {

                toplamHesap th = new toplamHesap();
                
                toplamFiyat = th.HesapToplami("SELECT [YemekFiyat],[UrunAdet] from tblSiparis inner join tblYemek on tblSiparis.UrunId=tblYemek.id where MasaNo=" +masaNo + " ");
                lblNakit.Text = Convert.ToString(toplamFiyat) + " TL ";
                int KrediKartiFiyat = ((toplamFiyat) + (toplamFiyat * 3 / 100)) / 4;
                lblKart.Text = Convert.ToString(KrediKartiFiyat) + " X 4 TL";
            }
            else
            {
                baglanti.Close();
                tableLytOdemeEkran.Visible = false;
                flowLytMasalar.Visible = true;
                flowLytMasalar.Controls.Clear();
                MasalariGetir();
                MessageBox.Show("Bu Masa'da kayıt yok !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();

        }
        public void MasalariGetir()
        {
            try
            {


                baglanti.Open();
                komutlarim = new SqlCommand("  select distinct tblMasaNumarasi.MasaNo,tblSiparis.MasaNo,tblMasaNumarasi.MasaDurum from tblMasaNumarasi left join tblSiparis on tblMasaNumarasi.id=tblSiparis.MasaNo ", baglanti);
                SqlDataReader dr = komutlarim.ExecuteReader();

                int btnbilgi = 0;
                for (int i = 0; i < 2; i++)
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
                        btnBilgi.Text = "Masa Boş";

                        btnBilgi.BackColor = Color.DarkGreen;
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
                    
                        if (dr[1].ToString() == "")
                        {
                       
                            btnMasa.BackColor = Color.DarkGreen;
                        btnMasa.ForeColor = Color.White;
                    }
                        else
                        {

                            btnMasa.BackColor = Color.DarkRed;
                        }

                    btnMasa.Click += BtnMasa_Click;
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
            masaNo = ((Button)sender).Text;
            flowLytMasalar.Visible = false;
            tableLytOdemeEkran.Visible = true;
            siparisListesiGetir(((Button)sender).Text);
            HesapTutar();
         }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            MasalariGetir();
        }

        
        private void btnOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komutlarim = new SqlCommand("delete from tblSiparis where MasaNo=" + masaNo + "", baglanti);
            komutlarim.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            komutlarim = new SqlCommand("insert into tblGecmisSiparisler values(" + toplamFiyat + "," + masaNo + ",GETDATE())", baglanti);
            komutlarim.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ödeme İşlemi Başarıyla Uygulandı", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableLytOdemeEkran.Visible = false;
            flowLytMasalar.Visible = true;
            flowLytMasalar.Controls.Clear();
            MasalariGetir();
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            
            btnKart.Enabled = false;
            btnNakit.Enabled = false;
            btnSecimiDegistir.Enabled = true;
            btnOde.Enabled = true;
        }

        private void btnKart_Click(object sender, EventArgs e)
        {
            
            btnKart.Enabled = false;
            btnNakit.Enabled = false;
            btnSecimiDegistir.Enabled = true;
            btnOde.Enabled = true;
        }

        private void btnSecimiDegistir_Click(object sender, EventArgs e)
        {
            
            btnKart.Enabled = true;
            btnNakit.Enabled = true;
            btnSecimiDegistir.Enabled = false;
            btnOde.Enabled = false;
        }
    }
}
