using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Runtime.Remoting.Messaging;// Bu katmanda bulunan proplara erişmek için referans olarak ekleyip bu classa dahil ettik.
namespace DataAccessLayer
{
    public class DALOgrenci
    {
        
        public static int OgrenciEkle(EntityOgrenci param)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO TBLOGRENCI (OGRAD, OGRSOYAD, OGRNUMARA, OGRFOTO, OGRSIFRE) VALUES (@p1, @p2, @p3, @p4, @p5)", Baglanti.Connection);


            if (insert.Connection.State != ConnectionState.Open) insert.Connection.Open();

            insert.Parameters.AddWithValue("@p1", param.AD);
            insert.Parameters.AddWithValue("@p2", param.SOYAD);
            insert.Parameters.AddWithValue("@p3", param.NUMARA);
            insert.Parameters.AddWithValue("@p4", param.FOTOGRAF);
            insert.Parameters.AddWithValue("@p5", param.SIFRE);


            return insert.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> Degerler = new List<EntityOgrenci>();
            SqlCommand select = new SqlCommand("SELECT * FROM TBLOGRENCI", Baglanti.Connection);

            if (select.Connection.State != ConnectionState.Open) select.Connection.Open();

            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci Ogrenci = new EntityOgrenci();
                Ogrenci.ID = Convert.ToInt32(dr[0].ToString());
                Ogrenci.AD = dr["OGRAD"].ToString();
                Ogrenci.SOYAD = dr["OGRSOYAD"].ToString();
                Ogrenci.NUMARA = dr["OGRNUMARA"].ToString();
                Ogrenci.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                Ogrenci.FOTOGRAF = dr["OGRFOTO"].ToString();
                Degerler.Add(Ogrenci);
            }
            dr.Close();
            return Degerler;
        }

        public static bool OgrenciSil(int id)
        {

            SqlCommand delete = new SqlCommand($"DELETE FROM TBLOGRENCI WHERE OGRID =@p1", Baglanti.Connection);
            if (delete.Connection.State != ConnectionState.Open) delete.Connection.Open();

            delete.Parameters.AddWithValue("@p1", id);
            return delete.ExecuteNonQuery()>0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> OgrenciBilgi =new List<EntityOgrenci>();
            SqlCommand Select = new SqlCommand($"SELECT * FROM TBLOGRENCI WHERE OGRID = {id}", Baglanti.Connection);
            Select.Parameters.AddWithValue("@p1", id);
            if (Select.Connection.State != ConnectionState.Open) Select.Connection.Open();

            SqlDataReader dr = Select.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci Ogrenci = new EntityOgrenci();
                
                Ogrenci.AD = dr["OGRAD"].ToString();
                Ogrenci.SOYAD = dr["OGRSOYAD"].ToString();
                Ogrenci.NUMARA = dr["OGRNUMARA"].ToString();
                Ogrenci.FOTOGRAF = dr["OGRFOTO"].ToString();
                Ogrenci.SIFRE = dr["OGRSIFRE"].ToString();
                OgrenciBilgi.Add(Ogrenci);
            }
            dr.Close();

            
            return OgrenciBilgi;
        }

        public static bool OgrenciGuncelle(EntityOgrenci Ogrenci)
        {
            SqlCommand update = new SqlCommand("UPDATE TBLOGRENCI SET OGRAD=@p1,OGRSOYAD=@p2,OGRNUMARA=@p3,OGRSIFRE=@p5 WHERE OGRID = @p6", Baglanti.Connection);
            update.Parameters.AddWithValue("@p1", Ogrenci.AD);
            update.Parameters.AddWithValue("@p2", Ogrenci.SOYAD);
            update.Parameters.AddWithValue("@p3", Ogrenci.NUMARA);
            //update.Parameters.AddWithValue("@p4", Ogrenci.FOTOGRAF);
            update.Parameters.AddWithValue("@p5", Ogrenci.SIFRE);
            update.Parameters.AddWithValue("@p6", Ogrenci.ID);

            if (update.Connection.State != ConnectionState.Open) update.Connection.Open();

            return update.ExecuteNonQuery() > 0;
        }
        
    }
}
