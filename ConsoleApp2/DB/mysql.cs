using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EGIO_DOTNET.DB
{
    internal class mysql
    {
        public IDbConnection sqlConnection;
        public string connectionString = "";

        public string DBMS;

        public static string dotnetpath = "C:/Users/202212002/source/repos/ConsoleApp2/ConsoleApp2/DB";

        public mysql(string inputDBMS = "Mysql")
        {
            string connectionFilePath = dotnetpath+"/connection.yaml";

            using (var readYaml = new StreamReader(connectionFilePath))
            {
                var yaml = new YamlStream();
                yaml.Load(readYaml);

                var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;

                string host, port, username, password, database, server;
                DBMS = inputDBMS;

                if (DBMS.Equals("Mysql"))
                {

                    host = mapping.Children[new YamlScalarNode(DBMS)]["Host"].ToString();
                    port = mapping.Children[new YamlScalarNode(DBMS)]["Port"].ToString();
                    username = mapping.Children[new YamlScalarNode(DBMS)]["Username"].ToString();
                    password = mapping.Children[new YamlScalarNode(DBMS)]["Password"].ToString();
                    database = mapping.Children[new YamlScalarNode(DBMS)]["Database"].ToString();
                    connectionString = $"Server={host};Port={port};Database={database};Uid={username};Pwd={password};";
                }
                else
                {
                    server = mapping.Children[new YamlScalarNode(DBMS)]["Server"].ToString();
                    username = mapping.Children[new YamlScalarNode(DBMS)]["Username"].ToString();
                    password = mapping.Children[new YamlScalarNode(DBMS)]["Password"].ToString();
                    database = mapping.Children[new YamlScalarNode(DBMS)]["Database"].ToString();

                    connectionString = $"TrustServerCertificate=true;Server={server};Database={database};Uid={username};Pwd={password};";

                }

            }
        }
        public string selectTest()
        {
            string returnString = "";
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand("call new_procedure", (MySqlConnection)sqlConnection);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();


                while (mySqlDataReader.Read())
                {
                    returnString += mySqlDataReader["id"].ToString();
                }
                sqlConnection.Close();
            }
            return returnString;

        }
        public void insertXMLTest(XmlNodeList xmlNodeList, string inputquery="", int type=0)
        {
            using (sqlConnection = DBMS.Equals("Mysql")? new MySqlConnection(connectionString) : new SqlConnection(connectionString)) {
               sqlConnection.Open();
            foreach (XmlElement xmlNode in xmlNodeList[0].ChildNodes)
            {
                try
                {
                    Console.Write(xmlNode.Name.ToString());
                    Console.Write("\t\t\t"+xmlNode.Attributes["value"].Value);
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.ToString());
                    continue;
                }
                finally
                {
                    Console.WriteLine();
                }
            }

                sqlConnection.Close();
            }

        }


        public void close()
        {
            sqlConnection.Close();
        }
    }
}
