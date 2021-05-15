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
        public static string UserName { get; private set; }

        public static int Point_ID { get; private set; }
        public static Dictionary<string, string> Items { get; private set; } = new Dictionary<string, string>();

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
                mySqlConn.ConnectionString = "Database=" + _baseName + ";Data Source=" + _serverName + ";User Id=root;Password=1234";
            }

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("show databases", mySqlConn);
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
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
                return false;
            }
        }
        
        internal static void AddCard(string clientSName, string clientName, string patron, string tel, string master, string service, string planDeliveryDat, string user, string typeReg, bool isDone, string dateReg, string sumToPay, string sumPay, string datePay, string payType, string prim, int point_ID)
        {
            MySqlConnection mySqlConn = new MySqlConnection();
            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string addCardQuery = $"call addcard('{clientSName}','{clientSName}','{patron}','{tel}','{master}','{service}','{planDeliveryDat}','{user}','{typeReg}',{isDone.ToString()},'{dateReg}','{sumToPay}','{sumPay}','{datePay}','{payType}','{prim}','{point_ID}')";

                //MessageBox.Show(addCardQuery,"Тестовый вывод sql");
                MySqlCommand sqlCommand = new MySqlCommand(addCardQuery, mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                sqlCommand.ExecuteNonQuery();
                mySqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");

            }
        }

        internal static bool Login(string _login, string _password, string _server, string _database)
        {
            if (SqlLogin(_login, _password))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool SqlLogin(string login, string password)
        {
            MySqlConnection mySqlConn = new MySqlConnection();

            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("select * from users where login ='" + login + "' and password ='" + password + "'", mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    UserName = dataReader.GetString(4);
                    Point_ID = dataReader.GetInt32(6);
                    dataReader.Close();
                    mySqlConn.Close();
                    return true;
                }
                else
                {
                    dataReader.Close();
                    mySqlConn.Close();
                    MessageBox.Show("Ничего не найдено. Проверьте правильность ввода логина и пароля", "Ошибка");
                    return false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
                return false;
            }
        }

        internal static DataTable GetList(string source)
        {
            DataTable table = new DataTable();
            MySqlConnection mySqlConn = new MySqlConnection();

            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string sqlString = $"call getlist('{source}')";
                mySqlConn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlString, mySqlConn);
                dataAdapter.Fill(table);
                mySqlConn.Close();
                return table;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
                return table;
            }
        }

        internal static void AddItem(string source, string text1, string text2, string text3, string text4, string point, int isActive, string urole)
        {
            MySqlConnection mySqlConn = new MySqlConnection();
            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string sqlString = $"call additemlist('{source}','{text1}','{text2}','{text3}','{text4}','{point}','{isActive}','{urole}')";
                MySqlCommand sqlCommand = new MySqlCommand(sqlString, mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                sqlCommand.ExecuteNonQuery();
                mySqlConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
        }

        internal static void SaveCard(string clientSName, string clientName, string patron, string tel, string master, string service, string planDeliveryDat, string user, string typeReg, bool isDone, string dateReg, string sumToPay, string sumPay, string datePay, string payType, string prim, int point_ID, string code)
        {
            MySqlConnection mySqlConn = new MySqlConnection();
            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string addCardQuery = $"call updatecard('{clientSName}','{clientSName}','{patron}','{tel}','{master}','{service}','{planDeliveryDat}','{user}','{typeReg}',{isDone.ToString()},'{dateReg}','{sumToPay}','{sumPay}','{datePay}','{payType}','{prim}','{point_ID}','{code}')";

                MessageBox.Show(addCardQuery, "Тестовый вывод sql");
                MySqlCommand sqlCommand = new MySqlCommand(addCardQuery, mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                sqlCommand.ExecuteNonQuery();
                mySqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");

            }
        }

        internal static void GetItem(string source, string itemCode)
        {
            Items.Clear();
            MySqlConnection mySqlConn = new MySqlConnection();

            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string sqlString = $"call getitem('{source}','{itemCode}')";
                MySqlCommand sqlCommand = new MySqlCommand(sqlString, mySqlConn);
                mySqlConn.Open();
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        Items.Add(dataReader.GetName(i), dataReader.GetValue(i).ToString());
                    }
                }


                dataReader.Close();
                mySqlConn.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
               
            }

        }

        internal static void EditItem(string source, string itemCode, string text1, string text2, string text3, string text4, string point, int  isActive, string urole)
        {
            MySqlConnection mySqlConn = new MySqlConnection();
            mySqlConn.ConnectionString = $"Database={baseName};Data Source={serverName};User Id=root;Password=1234";

            try
            {
                string sqlString = $"call edititem('{source}','{itemCode}','{text1}','{text2}','{text3}','{text4}','{point}','{isActive}','{urole}')";
                MySqlCommand sqlCommand = new MySqlCommand(sqlString, mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                sqlCommand.ExecuteNonQuery();
                mySqlConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
        }


    }

}


