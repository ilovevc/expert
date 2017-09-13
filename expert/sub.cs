using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;

namespace expert
{
    class sub
    {
        public static SqlConnection getcon()
        {
            return (new SqlConnection(ConfigurationManager.ConnectionStrings["expert.Properties.Settings.constr"].ToString()));
        }
    }
}
