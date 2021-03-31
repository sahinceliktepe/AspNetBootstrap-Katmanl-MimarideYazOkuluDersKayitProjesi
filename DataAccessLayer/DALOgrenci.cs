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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci(ogrAd, ogrSoyad, ogrNumara, ogrFoto, ogrSifre) values(@p1, @p2, @p3, @p4, @p5)",Baglanti.bgl);
            if(komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3",parametre.Numara);
            komut1.Parameters.AddWithValue("@p4",parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("select * from TblOgrenci", Baglanti.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["ogrId"].ToString());
                ent.Ad = dr["ogrAd"].ToString();
                ent.Soyad = dr["ogrSoyad"].ToString();
                ent.Numara = dr["ogrNumara"].ToString();
                ent.Fotograf = dr["ogrFoto"].ToString();
                ent.Sifre = dr["ogrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("delete from TblOgrenci where ogrId=@p1",Baglanti.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("select * from TblOgrenci where ogrId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["ogrAd"].ToString();
                ent.Soyad = dr["ogrSoyad"].ToString();
                ent.Numara = dr["ogrNumara"].ToString();
                ent.Fotograf = dr["ogrFoto"].ToString();
                ent.Sifre = dr["ogrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["ogrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update TblOgrenci set ogrAd=@p1, ogrSoyad=@p2, ogrNumara=@p3, ogrFoto=@p4, ogrSifre=@p5 where ogrId=@p6", Baglanti.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Ad);
            komut.Parameters.AddWithValue("@p2",deger.Soyad);
            komut.Parameters.AddWithValue("@p3",deger.Numara);
            komut.Parameters.AddWithValue("@p4",deger.Fotograf);
            komut.Parameters.AddWithValue("@p5",deger.Sifre);
            komut.Parameters.AddWithValue("@p6", deger.Id);
            return komut.ExecuteNonQuery() > 0;
        }

    }
}
