namespace Lab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Surname = new System.Windows.Forms.TextBox();
            this.NameOfOwner = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Passport = new System.Windows.Forms.TextBox();
            this.NumberOfDeposite = new System.Windows.Forms.TextBox();
            this.TypeOfDeposite = new System.Windows.Forms.ComboBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.DateOfStart = new System.Windows.Forms.DateTimePicker();
            this.SMSTrue = new System.Windows.Forms.RadioButton();
            this.SMSFalse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReadFromFile = new System.Windows.Forms.Button();
            this.HasInternet = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateOfopeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultOfSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultOfSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.deposites_list = new System.Windows.Forms.ListBox();
            this.read_from_file = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(119, 52);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 0;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // NameOfOwner
            // 
            this.NameOfOwner.Location = new System.Drawing.Point(119, 95);
            this.NameOfOwner.Name = "NameOfOwner";
            this.NameOfOwner.Size = new System.Drawing.Size(100, 20);
            this.NameOfOwner.TabIndex = 1;
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(119, 136);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 20);
            this.SecondName.TabIndex = 2;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(119, 179);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 3;
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(119, 219);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(100, 20);
            this.Passport.TabIndex = 4;
            this.Passport.TextChanged += new System.EventHandler(this.Passport_TextChanged);
            // 
            // NumberOfDeposite
            // 
            this.NumberOfDeposite.Location = new System.Drawing.Point(119, 262);
            this.NumberOfDeposite.Name = "NumberOfDeposite";
            this.NumberOfDeposite.Size = new System.Drawing.Size(100, 20);
            this.NumberOfDeposite.TabIndex = 5;
            // 
            // TypeOfDeposite
            // 
            this.TypeOfDeposite.FormattingEnabled = true;
            this.TypeOfDeposite.Items.AddRange(new object[] {
            "Накопительный",
            "Срочный",
            "До востребования"});
            this.TypeOfDeposite.Location = new System.Drawing.Point(119, 302);
            this.TypeOfDeposite.Name = "TypeOfDeposite";
            this.TypeOfDeposite.Size = new System.Drawing.Size(121, 21);
            this.TypeOfDeposite.TabIndex = 6;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(119, 348);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(100, 20);
            this.Balance.TabIndex = 7;
            // 
            // DateOfStart
            // 
            this.DateOfStart.Location = new System.Drawing.Point(119, 397);
            this.DateOfStart.Name = "DateOfStart";
            this.DateOfStart.Size = new System.Drawing.Size(200, 20);
            this.DateOfStart.TabIndex = 8;
            // 
            // SMSTrue
            // 
            this.SMSTrue.AutoSize = true;
            this.SMSTrue.Location = new System.Drawing.Point(6, 8);
            this.SMSTrue.Name = "SMSTrue";
            this.SMSTrue.Size = new System.Drawing.Size(40, 17);
            this.SMSTrue.TabIndex = 9;
            this.SMSTrue.TabStop = true;
            this.SMSTrue.Text = "Да";
            this.SMSTrue.UseVisualStyleBackColor = true;
            // 
            // SMSFalse
            // 
            this.SMSFalse.AutoSize = true;
            this.SMSFalse.Location = new System.Drawing.Point(67, 8);
            this.SMSFalse.Name = "SMSFalse";
            this.SMSFalse.Size = new System.Drawing.Size(44, 17);
            this.SMSFalse.TabIndex = 11;
            this.SMSFalse.TabStop = true;
            this.SMSFalse.Text = "Нет";
            this.SMSFalse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер вклада";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Тип вклада";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Баланс";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дата открытия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Подключить смс?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Подключить интернет-банкинг?";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 486);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(267, 38);
            this.Save.TabIndex = 24;
            this.Save.Text = "Сохранить данные";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SMSTrue);
            this.groupBox1.Controls.Add(this.SMSFalse);
            this.groupBox1.Location = new System.Drawing.Point(187, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 27);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.Location = new System.Drawing.Point(339, 486);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(308, 38);
            this.ReadFromFile.TabIndex = 31;
            this.ReadFromFile.Text = "Прочитать данные";
            this.ReadFromFile.UseVisualStyleBackColor = true;
            this.ReadFromFile.Click += new System.EventHandler(this.ReadFromFile_Click);
            // 
            // HasInternet
            // 
            this.HasInternet.AutoSize = true;
            this.HasInternet.Location = new System.Drawing.Point(193, 459);
            this.HasInternet.Name = "HasInternet";
            this.HasInternet.Size = new System.Drawing.Size(41, 17);
            this.HasInternet.TabIndex = 32;
            this.HasInternet.Text = "Да";
            this.HasInternet.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.SortToolStripMenuItem,
            this.saveInXMLToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SearchToolStripMenuItem.Text = "Search";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click_1);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TypeToolStripMenuItem,
            this.dateOfopeningToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.SortToolStripMenuItem.Text = "Sort";
            // 
            // TypeToolStripMenuItem
            // 
            this.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem";
            this.TypeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.TypeToolStripMenuItem.Text = "Type";
            this.TypeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click_1);
            // 
            // dateOfopeningToolStripMenuItem
            // 
            this.dateOfopeningToolStripMenuItem.Name = "dateOfopeningToolStripMenuItem";
            this.dateOfopeningToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dateOfopeningToolStripMenuItem.Text = "Date of opening";
            this.dateOfopeningToolStripMenuItem.Click += new System.EventHandler(this.dateOfopeningToolStripMenuItem_Click);
            // 
            // saveInXMLToolStripMenuItem
            // 
            this.saveInXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultOfSearchToolStripMenuItem,
            this.resultOfSortToolStripMenuItem});
            this.saveInXMLToolStripMenuItem.Name = "saveInXMLToolStripMenuItem";
            this.saveInXMLToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.saveInXMLToolStripMenuItem.Text = "Save in XML";
            // 
            // resultOfSearchToolStripMenuItem
            // 
            this.resultOfSearchToolStripMenuItem.Name = "resultOfSearchToolStripMenuItem";
            this.resultOfSearchToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resultOfSearchToolStripMenuItem.Text = "Result of last search";
            this.resultOfSearchToolStripMenuItem.Click += new System.EventHandler(this.resultOfSearchToolStripMenuItem_Click_1);
            // 
            // resultOfSortToolStripMenuItem
            // 
            this.resultOfSortToolStripMenuItem.Name = "resultOfSortToolStripMenuItem";
            this.resultOfSortToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resultOfSortToolStripMenuItem.Text = "Result of last sort";
            this.resultOfSortToolStripMenuItem.Click += new System.EventHandler(this.resultOfSortToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 99;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(31, 17);
            this.StatusLabel.Text = "Date";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // deposites_list
            // 
            this.deposites_list.FormattingEnabled = true;
            this.deposites_list.Location = new System.Drawing.Point(339, 52);
            this.deposites_list.Name = "deposites_list";
            this.deposites_list.Size = new System.Drawing.Size(591, 173);
            this.deposites_list.TabIndex = 101;
            // 
            // read_from_file
            // 
            this.read_from_file.FormattingEnabled = true;
            this.read_from_file.Location = new System.Drawing.Point(339, 243);
            this.read_from_file.Name = "read_from_file";
            this.read_from_file.Size = new System.Drawing.Size(591, 173);
            this.read_from_file.TabIndex = 102;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(339, 422);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(308, 38);
            this.Clear.TabIndex = 103;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 549);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.read_from_file);
            this.Controls.Add(this.deposites_list);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.HasInternet);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateOfStart);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.TypeOfDeposite);
            this.Controls.Add(this.NumberOfDeposite);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.NameOfOwner);
            this.Controls.Add(this.Surname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SecondName_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox NameOfOwner;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.TextBox NumberOfDeposite;
        private System.Windows.Forms.ComboBox TypeOfDeposite;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.DateTimePicker DateOfStart;
        private System.Windows.Forms.RadioButton SMSTrue;
        private System.Windows.Forms.RadioButton SMSFalse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReadFromFile;
        private System.Windows.Forms.CheckBox HasInternet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateOfopeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultOfSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultOfSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox deposites_list;
        private System.Windows.Forms.ListBox read_from_file;
        private System.Windows.Forms.Button Clear;
    }
}

