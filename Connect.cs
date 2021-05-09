using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRM
{
    static class Connect
    {
        public static List<string> DataBases { get; internal set; }

        private static string serverName;
        private static string baseName;

        internal static bool SettingsConnect(string _serverName, string _baseName = "")
        {
            serverName = _serverName;
            baseName = _baseName;
            DataBases = new List<string>();
            DataBases.Clear();
            MySqlConnection mySqlConn = new MySqlConnection();

            if (_baseName == "")
            {
                mySqlConn.ConnectionString = "Data Source=" + _serverName + ";User Id=root;Password=1234";
            }
            else
            {
                mySqlConn.ConnectionString = "Database="+ _baseName+";Data Source=" + _serverName + ";User Id=root;Password=1234";
            }

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("show databases",mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    DataBases.Add(dataReader.GetString(0));
                }
                

                dataReader.Close();
                mySqlConn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Ошибка");
                return false;
            }
        }

        internal static bool Login(string _login, string _password, string _server, string _database)
        {
            if (SettingsConnect(_server,_database))
            {
                //SqlQuery() ;
                MessageBox.Show("В процессе реализации");
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

}
