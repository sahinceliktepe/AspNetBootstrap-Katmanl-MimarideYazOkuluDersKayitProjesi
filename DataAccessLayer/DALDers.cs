using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        { 
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("select * from TblDersler", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["dersId"].ToString());
                ent.DersAd = dr["dersAd"].ToString();
                ent.Min = int.Parse(dr["dersMinKont"].ToString());
                ent.Max = int.Parse(dr["dersMaksKont"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TblBasvuruForm(ogrenciId, dersId) values(@p1, @p2)",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BasOgrId);
            komut.Parameters.AddWithValue("@p2", parametre.BasDersId);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }

    }
}
