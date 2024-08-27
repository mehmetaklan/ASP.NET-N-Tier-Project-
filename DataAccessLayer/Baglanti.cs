using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Baglanti
    {
       public static SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-9HDFLL4;Initial Catalog=DbSummerSchool;Integrated Security=True;");
    }
}
