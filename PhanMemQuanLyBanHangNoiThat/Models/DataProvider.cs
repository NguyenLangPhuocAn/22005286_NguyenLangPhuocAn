using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PhanMemQuanLyBanHangNoiThat.Models
{
    class DataProvider
    {
        public SqlConnection connection;
        public bool connect()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnectStr"].ConnectionString.ToString();
            connection = new SqlConnection(connectionStr);
            if(connection.State==ConnectionState.Closed|| connection.State == ConnectionState.Broken)
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Disconnect()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
