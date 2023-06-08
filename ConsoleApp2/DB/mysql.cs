using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGIO_DOTNET.DB
{
    internal class mysql
    {
        public static MySqlConnection mySqlConnection = new MySqlConnection(
            "Server = 127.0.0.1;" +
            "Port = 13306;" +
            "Database = RCV_API;" +
            "Uid = jyp;" +
            "Pwd = ^449qkrwndbs");

        public mysql()
        {
            mySqlConnection.Open();
        }
        public string selectTest()
        {
            MySqlCommand cmd = new MySqlCommand("call new_procedure", mySqlConnection);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            
            string returnString = "";

            while(mySqlDataReader.Read())
            {
                returnString += mySqlDataReader["id"].ToString();
            }

            return returnString;
        }
        public void close()
        {
            mySqlConnection.Close();
        }
    }
}
