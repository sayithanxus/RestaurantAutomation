using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    class toplamHesap
    {
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        public int HesapToplami(string sql)
        {
            try
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand(sql, baglanti);
                SqlDataReader dr = command.ExecuteReader();
                int toplam = 0;
                while (dr.Read())
                {
                    toplam = toplam + Convert.ToInt32(dr["YemekFiyat"]) * Convert.ToInt32(dr["UrunAdet"]);
                }

                dr.Close();

                baglanti.Close();
                return toplam;
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
