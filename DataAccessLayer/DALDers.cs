using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            List<EntityDers> Degerler = new List<EntityDers>();
            SqlCommand select = new SqlCommand("SELECT * FROM TBLDERS", Baglanti.Connection);

            if (select.Connection.State != ConnectionState.Open) select.Connection.Open();

            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                EntityDers Ders = new EntityDers();
                Ders.ID = Convert.ToInt32(dr[0].ToString());
                Ders.DERSAD = dr["DERSAD"].ToString();
                Ders.MIN = Convert.ToInt32(dr["DERSMINKONT"].ToString());
                Ders.MAX = Convert.ToInt32(dr["DERSMAKSKONT"].ToString());
                Degerler.Add(Ders);
            }
            dr.Close();
            return Degerler;
        }
        public static int TalepEkle(EntityBasvuru p)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO TBLBASVURUFORM (OGRENCIID,DERSID) VALUES (@p1,@p2)", Baglanti.Connection);
            
            insert.Parameters.AddWithValue("@p1",p.BASOGRID);
            insert.Parameters.AddWithValue("@p2", p.BASDERSID);

            if (insert.Connection.State != ConnectionState.Open) insert.Connection.Open();
            return insert.ExecuteNonQuery();
        }
    }
}
