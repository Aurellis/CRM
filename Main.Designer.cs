
namespace CRM
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.праваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаОтчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.lFullName = new System.Windows.Forms.Label();
            this.lDateTime = new System.Windows.Forms.Label();
            this.bAddCard = new System.Windows.Forms.Button();
            this.bOpenCard = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.tFastFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.спискиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.праваToolStripMenuItem,
            this.подразделенияToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // праваToolStripMenuItem
            // 
            this.праваToolStripMenuItem.Name = "праваToolStripMenuItem";
            this.праваToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.праваToolStripMenuItem.Text = "Права";
            this.праваToolStripMenuItem.Click += new System.EventHandler(this.праваToolStripMenuItem_Click);
            // 
            // подразделенияToolStripMenuItem
            // 
            this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
            this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.подразделенияToolStripMenuItem.Text = "Подразделения";
            this.подразделенияToolStripMenuItem.Click += new System.EventHandler(this.подразделенияToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаОтчетовToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // настройкаОтчетовToolStripMenuItem
            // 
            this.настройкаОтчетовToolStripMenuItem.Name = "настройкаОтчетовToolStripMenuItem";
            this.настройкаОтчетовToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.настройкаОтчетовToolStripMenuItem.Text = "Настройка отчетов";
            this.настройкаОтчетовToolStripMenuItem.Click += new System.EventHandler(this.настройкаОтчетовToolStripMenuItem_Click);
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мастераToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // мастераToolStripMenuItem
            // 
            this.мастераToolStripMenuItem.Name = "мастераToolStripMenuItem";
            this.мастераToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.мастераToolStripMenuItem.Text = "Мастера";
            this.мастераToolStripMenuItem.Click += new System.EventHandler(this.мастераToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(13, 67);
            this.dgOrders.MultiSelect = false;
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrders.Size = new System.Drawing.Size(777, 409);
            this.dgOrders.TabIndex = 1;
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            this.dgOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrders_CellMouseDoubleClick);
            // 
            // lFullName
            // 
            this.lFullName.AutoSize = true;
            this.lFullName.Location = new System.Drawing.Point(633, 479);
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(103, 13);
            this.lFullName.TabIndex = 2;
            this.lFullName.Text = "Имя пользователя";
            // 
            // lDateTime
            // 
            this.lDateTime.AutoSize = true;
            this.lDateTime.Location = new System.Drawing.Point(13, 479);
            this.lDateTime.Name = "lDateTime";
            this.lDateTime.Size = new System.Drawing.Size(0, 13);
            this.lDateTime.TabIndex = 3;
            // 
            // bAddCard
            // 
            this.bAddCard.Location = new System.Drawing.Point(16, 27);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(95, 34);
            this.bAddCard.TabIndex = 4;
            this.bAddCard.Text = "Добавить новую заяку";
            this.bAddCard.UseVisualStyleBackColor = true;
            this.bAddCard.Click += new System.EventHandler(this.bAddCard_Click);
            // 
            // bOpenCard
            // 
            this.bOpenCard.Location = new System.Drawing.Point(117, 27);
            this.bOpenCard.Name = "bOpenCard";
            this.bOpenCard.Size = new System.Drawing.Size(99, 34);
            this.bOpenCard.TabIndex = 5;
            this.bOpenCard.Text = "Открыть карточку заявки";
            this.bOpenCard.UseVisualStyleBackColor = true;
            this.bOpenCard.Click += new System.EventHandler(this.bOpenCard_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(222, 27);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(95, 34);
            this.bPrint.TabIndex = 6;
            this.bPrint.Text = "Печать";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // tFastFilter
            // 
            this.tFastFilter.Location = new System.Drawing.Point(648, 35);
            this.tFastFilter.Name = "tFastFilter";
            this.tFastFilter.Size = new System.Drawing.Size(142, 20);
            this.tFastFilter.TabIndex = 8;
            this.tFastFilter.TextChanged += new System.EventHandler(this.tFastFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Быстрый поиск";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(323, 27);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(95, 34);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.Text = "Обновить";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 501);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tFastFilter);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bOpenCard);
            this.Controls.Add(this.bAddCard);
            this.Controls.Add(this.lDateTime);
            this.Controls.Add(this.lFullName);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета заявок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem праваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаОтчетовToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.Label lDateTime;
        private System.Windows.Forms.Button bAddCard;
        private System.Windows.Forms.Button bOpenCard;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.TextBox tFastFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem мастераToolStripMenuItem;
        private System.Windows.Forms.Button bUpdate;
    }
}