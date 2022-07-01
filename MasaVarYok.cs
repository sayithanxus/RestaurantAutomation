using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması
{
    class MasaVarYok
    {
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=RestoranApp;Trusted_Connection=yes");
        SqlCommand komutlarim;
        public int Masa(String sql,String masa)
        {
            int masaVar = 0;


            baglanti.Open();
            komutlarim = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komutlarim.ExecuteReader();

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (masa == dr[0].ToString())
                    {
                        masaVar++;
                    }

                }

            }
            baglanti.Close();



            return masaVar;
        }
    }
}
