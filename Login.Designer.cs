
namespace CRM
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tPassWord = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCheckSettings = new System.Windows.Forms.Button();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tServerHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя (логин)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // tLogin
            // 
            this.tLogin.Location = new System.Drawing.Point(29, 25);
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(202, 20);
            this.tLogin.TabIndex = 2;
            this.tLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tPassWord
            // 
            this.tPassWord.Location = new System.Drawing.Point(29, 73);
            this.tPassWord.Name = "tPassWord";
            this.tPassWord.PasswordChar = '*';
            this.tPassWord.Size = new System.Drawing.Size(202, 20);
            this.tPassWord.TabIndex = 3;
            this.tPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(13, 110);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(87, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Вход";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bSettings
            // 
            this.bSettings.Location = new System.Drawing.Point(156, 110);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(86, 23);
            this.bSettings.TabIndex = 5;
            this.bSettings.Text = "Настройки >>";
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCheckSettings);
            this.groupBox1.Controls.Add(this.cbDataBases);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tServerHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки подключения к базе данных";
            // 
            // bCheckSettings
            // 
            this.bCheckSettings.Location = new System.Drawing.Point(38, 119);
            this.bCheckSettings.Name = "bCheckSettings";
            this.bCheckSettings.Size = new System.Drawing.Size(152, 23);
            this.bCheckSettings.TabIndex = 4;
            this.bCheckSettings.Text = "Проверка подключения";
            this.bCheckSettings.UseVisualStyleBackColor = true;
            this.bCheckSettings.Click += new System.EventHandler(this.bCheckSettings_Click);
            // 
            // cbDataBases
            // 
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(16, 92);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(202, 21);
            this.cbDataBases.TabIndex = 3;
            this.cbDataBases.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbDataBases_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "База данных";
            // 
            // tServerHost
            // 
            this.tServerHost.Location = new System.Drawing.Point(16, 43);
            this.tServerHost.Name = "tServerHost";
            this.tServerHost.Size = new System.Drawing.Size(202, 20);
            this.tServerHost.TabIndex = 1;
            this.tServerHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Компьютер сервера БД";
            // 
            // Login
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tPassWord);
            this.Controls.Add(this.tLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.TextBox tPassWord;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tServerHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCheckSettings;
    }
}

