using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CRM
{
    public partial class Login : Form
    {
        string baseFolder;
        string programmFolder;
        string settingsPath;
        private bool connectState = false;

        public Login()
        {
            InitializeComponent();
            this.Height = 180;

            baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            programmFolder = Path.Combine(baseFolder, "CRM_System");
            settingsPath = Path.Combine(programmFolder, @"Settings\ConnectSettings.json");

            if (File.Exists(settingsPath))
            {
                string connSettingsString = File.ReadAllText(settingsPath);
                ConnectSettings connectSettings = JsonSerializer.Deserialize<ConnectSettings>(connSettingsString);

                tServerHost.Text = connectSettings.Server;
                cbDataBases.Items.Clear();
                cbDataBases.Items.Add(connectSettings.DataBase);
                cbDataBases.SelectedItem = connectSettings.DataBase;
                tLogin.Text = connectSettings.UserName;
                tDbUser.Text = connectSettings.DataBaseUser;
                tDbPass.Text = connectSettings.DataBasePass;
                connectState = true;
            }

        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            if (this.Height == 180)
            {
                bSettings.Text = "Настройки <<";
                this.Height = 350;
            }
            else
            {
                if ( tServerHost.Text == string.Empty || tServerHost.Text.Contains(' ') || !Connect.SettingsConnect(tServerHost.Text,"",tDbUser.Text,tDbPass.Text))
                {
                    MessageBox.Show("Адрес сервера не указан или содержит недопустимые символы"); 
                }
                else
                {
                    bSettings.Text = "Настройки >>";
                    this.Height = 180;
                }
            }
        }

        private void bCheckSettings_Click(object sender, EventArgs e)
        {
            if (Connect.SettingsConnect(tServerHost.Text, cbDataBases.SelectedItem.ToString(), tDbUser.Text, tDbPass.Text))
            {
                MessageBox.Show("Успешное подключение");
                try
                {
                    ConnectSettings connectSettings = new ConnectSettings() { Server = tServerHost.Text, DataBase = cbDataBases.SelectedItem.ToString(), UserName = tLogin.Text, DataBaseUser = tDbUser.Text, DataBasePass = tDbPass.Text };
                    string connectSettingsJson = JsonSerializer.Serialize<ConnectSettings>(connectSettings);

                    if (!Directory.Exists(Path.Combine(programmFolder, @"Settings")))
                    {
                        Directory.CreateDirectory(Path.Combine(programmFolder, @"Settings"));
                    }

                    File.WriteAllText(settingsPath, connectSettingsJson);
                    connectState = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Подключение не удалось. Проверьте данные");
            }
        }

        private void cbDataBases_MouseUp(object sender, MouseEventArgs e)
        {
            if (tServerHost.Text == string.Empty || tServerHost.Text.Contains(' '))
            {
                MessageBox.Show("Адрес сервера не указан или содержит недопустимые символы");
            }
            else
            {
                if (Connect.SettingsConnect(tServerHost.Text,"",tDbUser.Text,tDbPass.Text))
                {
                    cbDataBases.Items.Clear();
                    cbDataBases.Items.AddRange(Connect.DataBases.ToArray()) ;
                }
            }
            
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (connectState && Connect.SettingsConnect(tServerHost.Text, cbDataBases.SelectedItem.ToString(),tDbUser.Text,tDbPass.Text))
            {
                if (tLogin.Text != string.Empty && tPassWord.Text != string.Empty)
                {
                    if (Connect.Login(tLogin.Text, tPassWord.Text, tServerHost.Text, cbDataBases.SelectedItem.ToString()))
                    {

                        try
                        {
                            if (File.Exists(settingsPath))
                            {
                                File.Delete(settingsPath);
                            }

                            ConnectSettings connectSettings = new ConnectSettings() { Server = tServerHost.Text, DataBase = cbDataBases.SelectedItem.ToString(), UserName = tLogin.Text, DataBaseUser = tDbUser.Text, DataBasePass = tDbPass.Text };
                            string connectSettingsJson = JsonSerializer.Serialize<ConnectSettings>(connectSettings);

                            if (!Directory.Exists(Path.Combine(programmFolder, @"Settings")))
                            {
                                Directory.CreateDirectory(Path.Combine(programmFolder, @"Settings"));
                            }

                            File.WriteAllText(settingsPath, connectSettingsJson);
                            connectState = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка");
                        }

                        Main mainWindow = new Main(tLogin.Text, tPassWord.Text, tServerHost.Text, cbDataBases.SelectedItem.ToString());
                        mainWindow.Show();
                        this.ShowInTaskbar = false;
                        this.Hide();
                    }
                }                
                else
                {
                    MessageBox.Show("Логин или пароль не введен", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте параметры подключения!","Ошибка!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height == 350)
            {               
                this.Height = 440;
            }
            else
            {
                if (tServerHost.Text == string.Empty || tServerHost.Text.Contains(' ') || !Connect.SettingsConnect(tServerHost.Text))
                {
                    MessageBox.Show("Адрес сервера не указан или содержит недопустимые символы");
                }
                else
                {                    
                    this.Height = 350;
                }
            }
        }
    }
}
