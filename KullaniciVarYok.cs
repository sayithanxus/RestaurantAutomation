using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    class KullaniciVarYok
    {
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        public int KullaniciKontrol(String sql, String kulid)
        {
            int kulVar = 0;


            baglanti.Open();
            komutlarim = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komutlarim.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (kulid == dr[0].ToString())
                    {
                        kulVar++;
                    }

                }

            }
            baglanti.Close();



            return kulVar;
        }
    }
}
