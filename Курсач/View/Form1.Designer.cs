namespace Курсач
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ChgName = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.NameOfItemChangeLable = new System.Windows.Forms.Label();
            this.buttonSelectToChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownChangePrice = new System.Windows.Forms.NumericUpDown();
            this.buttonChangePrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDownChangeCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поступление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отгрузка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfItem,
            this.Count,
            this.Mesure,
            this.Price,
            this.DateOfLast});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // NameOfItem
            // 
            this.NameOfItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameOfItem.HeaderText = "Наименование";
            this.NameOfItem.Name = "NameOfItem";
            this.NameOfItem.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Mesure
            // 
            this.Mesure.HeaderText = "Ед. Изм";
            this.Mesure.Name = "Mesure";
            this.Mesure.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // DateOfLast
            // 
            this.DateOfLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfLast.HeaderText = "Дата";
            this.DateOfLast.Name = "DateOfLast";
            this.DateOfLast.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Склад";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ChgName
            // 
            this.ChgName.Location = new System.Drawing.Point(14, 124);
            this.ChgName.Name = "ChgName";
            this.ChgName.Size = new System.Drawing.Size(115, 23);
            this.ChgName.TabIndex = 6;
            this.ChgName.Text = "Изм. Имя";
            this.ChgName.UseVisualStyleBackColor = true;
            this.ChgName.Click += new System.EventHandler(this.ChgName_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(14, 98);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(115, 20);
            this.textBoxNewName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownChangeCount);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonChangePrice);
            this.groupBox2.Controls.Add(this.numericUpDownChangePrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSelectToChange);
            this.groupBox2.Controls.Add(this.NameOfItemChangeLable);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.textBoxNewName);
            this.groupBox2.Controls.Add(this.ChgName);
            this.groupBox2.Location = new System.Drawing.Point(19, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 149);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Наименование";
            // 
            // NameOfItemChangeLable
            // 
            this.NameOfItemChangeLable.AutoSize = true;
            this.NameOfItemChangeLable.Location = new System.Drawing.Point(9, 33);
            this.NameOfItemChangeLable.Name = "NameOfItemChangeLable";
            this.NameOfItemChangeLable.Size = new System.Drawing.Size(43, 13);
            this.NameOfItemChangeLable.TabIndex = 9;
            this.NameOfItemChangeLable.Text = "(Пусто)";
            // 
            // buttonSelectToChange
            // 
            this.buttonSelectToChange.Location = new System.Drawing.Point(120, 16);
            this.buttonSelectToChange.Name = "buttonSelectToChange";
            this.buttonSelectToChange.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectToChange.TabIndex = 10;
            this.buttonSelectToChange.Text = "Выбор";
            this.buttonSelectToChange.UseVisualStyleBackColor = true;
            this.buttonSelectToChange.Click += new System.EventHandler(this.buttonSelectToChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Новое наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Новая Цена";
            // 
            // numericUpDownChangePrice
            // 
            this.numericUpDownChangePrice.Location = new System.Drawing.Point(172, 98);
            this.numericUpDownChangePrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownChangePrice.Name = "numericUpDownChangePrice";
            this.numericUpDownChangePrice.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownChangePrice.TabIndex = 13;
            // 
            // buttonChangePrice
            // 
            this.buttonChangePrice.Location = new System.Drawing.Point(172, 125);
            this.buttonChangePrice.Name = "buttonChangePrice";
            this.buttonChangePrice.Size = new System.Drawing.Size(75, 23);
            this.buttonChangePrice.TabIndex = 14;
            this.buttonChangePrice.Text = "Изм. Цену";
            this.buttonChangePrice.UseVisualStyleBackColor = true;
            this.buttonChangePrice.Click += new System.EventHandler(this.buttonChangePrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Новое количество";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Изм. кол-во";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDownChangeCount
            // 
            this.numericUpDownChangeCount.Location = new System.Drawing.Point(292, 98);
            this.numericUpDownChangeCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownChangeCount.Name = "numericUpDownChangeCount";
            this.numericUpDownChangeCount.Size = new System.Drawing.Size(97, 20);
            this.numericUpDownChangeCount.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLast;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ChgName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NameOfItemChangeLable;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSelectToChange;
        private System.Windows.Forms.Button buttonChangePrice;
        private System.Windows.Forms.NumericUpDown numericUpDownChangePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownChangeCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

