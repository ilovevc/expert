using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;
using System.Data.SqlClient;

namespace expert
{
    class sub
    {
        public static SqlConnection getcon()
        {
            return (new SqlConnection(ConfigurationManager.ConnectionStrings["expert.Properties.Settings.constr"].ToString()));
        }

        public static void writelog(string msg)
        {
            string sql = "insert into log values(@tim,@msg)";
            SqlCommand cmd = new SqlCommand(sql, getcon());
            cmd.Parameters.AddWithValue("tim", DateTime.Now);
            cmd.Parameters.AddWithValue("msg", msg);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
