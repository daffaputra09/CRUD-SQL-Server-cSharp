using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataGuru
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-K1THODN\\SQLEXPRESS;Initial Catalog=db_guru;Integrated Security=True";
            return conn;
        }
    }
}