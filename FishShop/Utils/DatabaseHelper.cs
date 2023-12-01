using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Utils
{
    internal class DatabaseHelper
    {
        public static String serverName;
        public static String databaseName;
        public static String userId;
        public static String password;

        public static SqlConnection getConnection()
        {
            String strCon = "server =" + serverName +
                "; Initial Catalog = " + databaseName +
                "; uid = " + userId +
                "; pwd = " + password;
            return new SqlConnection(strCon);
        }
    }
}
