﻿using System;
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

        internal static void AddCard(string clientSName, string clientName, string patron, string tel, string master, string service, string planDeliveryDat, string user, string typeReg, bool isDone, string dateReg, string sumToPay, string sumPay, string datePay, string payType, string prim)
        {
            MySqlConnection mySqlConn = new MySqlConnection();
            mySqlConn.ConnectionString = "Database=" + baseName + ";Data Source=" + serverName + ";User Id=root;Password=1234";

            try
            {
                string addCardQuery = "call addcard('" + clientSName + "','" + clientSName + "','" + patron + "','" + tel + "','" + master+"','"+service+"','"+planDeliveryDat+"','"+user+"','"+typeReg+"',"+isDone+",'"+dateReg+"',"+sumToPay+","+sumPay+",'"+datePay+"','"+payType+"','"+prim+"'";

                MessageBox.Show(addCardQuery,"Тестовый вывод sql");
            //    MySqlCommand sqlCommand = new MySqlCommand(addCardQuery, mySqlConn);
            //    sqlCommand.CommandType = CommandType.Text;
            //    mySqlConn.Open();
            //    MySqlDataReader dataReader = sqlCommand.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        DataBases.Add(dataReader.GetString(0));
            //    }


            //    dataReader.Close();
            //    mySqlConn.Close();
            //    return true;
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

            mySqlConn.ConnectionString = "Database=" + baseName + ";Data Source=" + serverName + ";User Id=root;Password=1234";

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("select * from users where login ='"+login+"' and password ='"+password+"'", mySqlConn);
                sqlCommand.CommandType = CommandType.Text;
                mySqlConn.Open();
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    UserName = dataReader.GetString(4);
                    dataReader.Close();
                    mySqlConn.Close();
                    return true;
                }
                else
                {
                    dataReader.Close();
                    mySqlConn.Close();
                    MessageBox.Show("Ничего не найдено. Проверьте правильность ввода логина и пароля","Ошибка");
                    return false;
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
                return false;
            }
        }
    }

}
