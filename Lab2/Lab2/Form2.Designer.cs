namespace Lab2
{
    partial class Form2
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
            this.Balance_textBox = new System.Windows.Forms.TextBox();
            this.SearchResult_List = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Type_Listbox = new System.Windows.Forms.ComboBox();
            this.SecondName_textBox = new System.Windows.Forms.TextBox();
            this.Number_textBox = new System.Windows.Forms.TextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Balance_textBox
            // 
            this.Balance_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_textBox.Location = new System.Drawing.Point(298, 142);
            this.Balance_textBox.Name = "Balance_textBox";
            this.Balance_textBox.Size = new System.Drawing.Size(222, 24);
            this.Balance_textBox.TabIndex = 58;
            // 
            // SearchResult_List
            // 
            this.SearchResult_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchResult_List.FormattingEnabled = true;
            this.SearchResult_List.ItemHeight = 15;
            this.SearchResult_List.Location = new System.Drawing.Point(2, 378);
            this.SearchResult_List.Name = "SearchResult_List";
            this.SearchResult_List.Size = new System.Drawing.Size(583, 109);
            this.SearchResult_List.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(241, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Result of search";
            // 
            // Type_Listbox
            // 
            this.Type_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_Listbox.FormattingEnabled = true;
            this.Type_Listbox.Items.AddRange(new object[] {
            "Накопительный",
            "Срочный",
            "До востребования"});
            this.Type_Listbox.Location = new System.Drawing.Point(298, 99);
            this.Type_Listbox.Name = "Type_Listbox";
            this.Type_Listbox.Size = new System.Drawing.Size(222, 26);
            this.Type_Listbox.TabIndex = 55;
            // 
            // SecondName_textBox
            // 
            this.SecondName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName_textBox.Location = new System.Drawing.Point(298, 254);
            this.SecondName_textBox.Name = "SecondName_textBox";
            this.SecondName_textBox.Size = new System.Drawing.Size(222, 24);
            this.SecondName_textBox.TabIndex = 54;
            // 
            // Number_textBox
            // 
            this.Number_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_textBox.Location = new System.Drawing.Point(298, 62);
            this.Number_textBox.Name = "Number_textBox";
            this.Number_textBox.Size = new System.Drawing.Size(222, 24);
            this.Number_textBox.TabIndex = 53;
            this.Number_textBox.TextChanged += new System.EventHandler(this.Number_textBox_TextChanged);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(334, 296);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(85, 42);
            this.Clear_button.TabIndex = 52;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click_1);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(190, 296);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(85, 42);
            this.Search_button.TabIndex = 51;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Баланс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Тип вклада";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Номер счёта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Write, what you will find";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(47, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Фамилия";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(298, 214);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(222, 24);
            this.Name_textBox.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(47, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Имя";
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_textBox.Location = new System.Drawing.Point(298, 178);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(222, 24);
            this.Surname_textBox.TabIndex = 60;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 505);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Balance_textBox);
            this.Controls.Add(this.SearchResult_List);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type_Listbox);
            this.Controls.Add(this.SecondName_textBox);
            this.Controls.Add(this.Number_textBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Balance_textBox;
        public System.Windows.Forms.ListBox SearchResult_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Type_Listbox;
        private System.Windows.Forms.TextBox SecondName_textBox;
        private System.Windows.Forms.TextBox Number_textBox;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Surname_textBox;
    }
}