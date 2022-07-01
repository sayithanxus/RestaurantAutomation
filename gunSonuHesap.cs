using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    class gunSonuHesap
    {
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        public int HesapToplami(string sql)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand(sql, baglanti);
            SqlDataReader dr = command.ExecuteReader();
            int toplam = 0;
            while (dr.Read())
            {
                toplam = toplam + Convert.ToInt32(dr["HesapTutari"]);
            }

            dr.Close();

            baglanti.Close();
            return toplam;


        }
        public int BelliTarihHesapToplami(string sql2)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand(sql2, baglanti);
            SqlDataReader dr = command.ExecuteReader();
            int toplam = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    toplam = toplam + Convert.ToInt32(dr["HesapTutari"]);
                }
            }
            else
            {

            }


            dr.Close();

            baglanti.Close();
            return toplam;


        }
    }
}
