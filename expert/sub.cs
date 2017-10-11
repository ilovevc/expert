using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Management;
using System.Security.Cryptography;


namespace expert
{
    class sub
    {
        public static bool IsReg
        {
            get;
            set;
        }

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

        public static string GetMD5(string text)
        {
            MD5 md = MD5.Create();
            byte[] b = md.ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(b).Replace("-", "");


        }

        public static string getcupid()
        {
            string hdid = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject m in moc)
            {
                hdid += m.Properties["ProcessorID"].Value.ToString();

            }
            hdid = GetMD5(hdid);
            return hdid;
        }
        public static string getKEY()
        {
            string hdid = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject m in moc)
            {
                hdid += m.Properties["ProcessorID"].Value.ToString();

            }
            hdid = GetMD5(hdid);
            string tmp = GetMD5(hdid + "zhaomiduo");
            tmp = tmp.Substring(0, 20);
            string key = "";
            for (int i = 0; i < 20; i = i + 4)
            {
                key += tmp.Substring(i, 4);
                if (i < 16)
                    key += "-";
            }
            return key;
        }
        public static string readregkey()
        {
            return ConfigurationManager.AppSettings["regkey"].ToString();
        }
        public static bool writeregkey(string key)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["regkey"].Value = key;
                config.Save(ConfigurationSaveMode.Modified);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsRegsoft()
        {
            if (readregkey() == getKEY())
                return true;
            else
                return false;
        }
    }
}
