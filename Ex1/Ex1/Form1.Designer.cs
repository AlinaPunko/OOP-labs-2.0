namespace Ex1
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
            this.Indexes = new System.Windows.Forms.ListView();
            this.Numbers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Indexes
            // 
            this.Indexes.Location = new System.Drawing.Point(38, 38);
            this.Indexes.Name = "Indexes";
            this.Indexes.Size = new System.Drawing.Size(85, 229);
            this.Indexes.TabIndex = 0;
            this.Indexes.UseCompatibleStateImageBehavior = false;
            // 
            // Numbers
            // 
            this.Numbers.Location = new System.Drawing.Point(158, 38);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(85, 229);
            this.Numbers.TabIndex = 1;
            this.Numbers.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(387, 90);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 20);
            this.Max.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(387, 151);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(100, 20);
            this.Index.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Максимальный элемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Индекс";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(266, 214);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Индекс1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 283);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.Indexes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Indexes;
        private System.Windows.Forms.ListView Numbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Index;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search;
    }
}

