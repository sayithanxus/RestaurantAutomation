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
    public partial class frmMasaListele : Form
    {
        public frmMasaListele()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        int masaVar = 0;
        MasaVarYok masa;
        public void MasalariGetir()
        {
            try
            {


                baglanti.Open();
                komutlarim = new SqlCommand("  select distinct tblMasaNumarasi.MasaNo,tblSiparis.MasaNo,tblMasaNumarasi.MasaDurum from tblMasaNumarasi left join tblSiparis on tblMasaNumarasi.id=tblSiparis.MasaNo ", baglanti);
                SqlDataReader dr = komutlarim.ExecuteReader();




                while (dr.Read())
                {

                    Button btnMasa = new Button();
                    btnMasa.Text = dr[0].ToString();

                    btnMasa.Size = new Size(120, 120);
                    btnMasa.ForeColor = Color.White;
                    btnMasa.Font = new Font("Georgia", 20, FontStyle.Bold);
                    btnMasa.Click += BtnMasa_Click;
                    if (dr[2].ToString()=="True")
                    {
                        if (dr[1].ToString() == "")
                        {
                            btnMasa.BackColor = Color.DarkGreen;
                        }
                        else
                        {

                            btnMasa.BackColor = Color.DarkRed;
                        }

                       
                    }
                    else
                    {
                        btnMasa.BackColor = Color.DarkGray;
                    }

                    flowLayoutMasalar.Controls.Add(btnMasa);



                }
                baglanti.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public string eskiMasaNo = "";
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            eskiMasaNo = ((Button)sender).Text;
            txtMasa.Text = ((Button)sender).Text;
            baglanti.Open();
            komutlarim = new SqlCommand("select MasaDurum from tblMasaNumarasi where MasaNo=@masaNo", baglanti);
            komutlarim.Parameters.AddWithValue("@masaNo", Convert.ToInt32(txtMasa.Text));
            komutlarim.ExecuteNonQuery();
            SqlDataReader dr = komutlarim.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString()=="True")
                {
                    txtMasaDurum.Text =Convert.ToString(1) ;
                }
                else
                {
                    txtMasaDurum.Text = Convert.ToString(0);
                }
                
            }
            baglanti.Close();
        }

        public void DoluMasaSayisi()
        {
            try
            {
                int[] i = { };
                int a = 0;
                baglanti.Open();

                komutlarim = new SqlCommand("SELECT distinct MasaNo from tblSiparis", baglanti);
                SqlDataReader dr = komutlarim.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        a++;
                    }
                    lblTplmSprsSayisi.Text = Convert.ToString(a);

                }

                baglanti.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ToplamSiparisSayisi()
        {
            try
            {
                baglanti.Open();
                komutlarim = new SqlCommand("SELECT DISTINCT count(id) FROM tblSiparis", baglanti);
                SqlDataReader dr = komutlarim.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        lblDoluMasaSayisi.Text = dr[0].ToString();
                       
                    }

                }
                baglanti.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show("Hata" + e, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void frmMasaListele_Load(object sender, EventArgs e)
        {
            MasalariGetir();
            DoluMasaSayisi();
            ToplamSiparisSayisi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMasa.Text != "" || txtMasaDurum.Text!= "")
            {
                masa = new MasaVarYok();
                masaVar = masa.Masa("SELECT MasaNo FROM tblMasaNumarasi", txtMasa.Text);
                if (masaVar == 0)
                {
                    if (txtMasaDurum.Text == "1" || txtMasaDurum.Text=="0")
                    {
                        baglanti.Open();
                        komutlarim = new SqlCommand("insert into tblMasaNumarasi(MasaNo,MasaDurum) values(@masaNo,@masaDurum)", baglanti);
                        komutlarim.Parameters.AddWithValue("@masaNo", Convert.ToInt32(txtMasa.Text));
                        komutlarim.Parameters.AddWithValue("@masaDurum", txtMasaDurum.Text);
                        komutlarim.ExecuteNonQuery();
                        baglanti.Close();
                        flowLayoutMasalar.Controls.Clear();
                        MasalariGetir();
                        DoluMasaSayisi();
                        ToplamSiparisSayisi();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Masa Durumuna 0 veya 1 giriniz !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                else if (masaVar != 0)
                {
                    MessageBox.Show("Böyle bir masa var !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMasa.Text != "" || txtMasaDurum.Text != "")
            {
                masa = new MasaVarYok();
                masaVar = masa.Masa("SELECT MasaNo FROM tblMasaNumarasi", txtMasa.Text);
                if (masaVar != 0)
                {
                    if (txtMasaDurum.Text == "1" || txtMasaDurum.Text == "0")
                    {
                        baglanti.Open();
                        komutlarim = new SqlCommand("update tblMasaNumarasi set MasaNo=@masaNo,MasaDurum=@masaDurum where MasaNo=@eskiMasa", baglanti);
                        komutlarim.Parameters.AddWithValue("@masaNo", Convert.ToInt32(txtMasa.Text));
                        komutlarim.Parameters.AddWithValue("@masaDurum", txtMasaDurum.Text);
                        komutlarim.Parameters.AddWithValue("@eskiMasa", eskiMasaNo);
                        komutlarim.ExecuteNonQuery();
                        baglanti.Close();
                        flowLayoutMasalar.Controls.Clear();
                        MasalariGetir();
                        DoluMasaSayisi();
                        ToplamSiparisSayisi();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Masa Durumuna 0 veya 1 giriniz !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (masaVar != 0)
                {
                    MessageBox.Show("Böyle bir masa yok !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
       
        private void btnSipariseKapat_Click(object sender, EventArgs e)
        {
            if (txtMasa.Text != "" || txtMasaDurum.Text != "")
            {
                masa = new MasaVarYok();
                masaVar= masa.Masa("SELECT MasaNo FROM tblMasaNumarasi", txtMasa.Text);
               
                if (masaVar != 0)
                {
                    if (txtMasaDurum.Text == "1" || txtMasaDurum.Text == "0")
                    {
                        baglanti.Open();
                        komutlarim = new SqlCommand("update tblMasaNumarasi set MasaDurum=@masaDurum where MasaNo=@masaNo", baglanti);
                        
                        komutlarim.Parameters.AddWithValue("@masaDurum", Convert.ToString(0));
                        komutlarim.Parameters.AddWithValue("@masaNo", Convert.ToInt32(txtMasa.Text));
                        komutlarim.ExecuteNonQuery();
                        baglanti.Close();
                        flowLayoutMasalar.Controls.Clear();
                        MasalariGetir();
                        DoluMasaSayisi();
                        ToplamSiparisSayisi();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Masa Durumuna 0 veya 1 giriniz !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (masaVar != 0)
                {
                    MessageBox.Show("Böyle bir masa yok !", "Masa İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
