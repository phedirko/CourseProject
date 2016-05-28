namespace Курсач.View
{
    partial class FormIn
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
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.NameIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.CountInputBox = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDownInPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMeasure = new System.Windows.Forms.GroupBox();
            this.RBInKgs = new System.Windows.Forms.RadioButton();
            this.RBInPcs = new System.Windows.Forms.RadioButton();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectOfAv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOfAvIt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumericAvPlus = new System.Windows.Forms.NumericUpDown();
            this.AddToExst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInPrice)).BeginInit();
            this.groupBoxMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAvPlus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameIn,
            this.Count,
            this.MeasureType,
            this.Price,
            this.DateIn});
            this.ItemsGridView.Location = new System.Drawing.Point(7, 19);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGridView.Size = new System.Drawing.Size(547, 102);
            this.ItemsGridView.TabIndex = 0;
            // 
            // NameIn
            // 
            this.NameIn.HeaderText = "Наименование";
            this.NameIn.Name = "NameIn";
            this.NameIn.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // MeasureType
            // 
            this.MeasureType.HeaderText = "Ед Изм.";
            this.MeasureType.Name = "MeasureType";
            this.MeasureType.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // DateIn
            // 
            this.DateIn.HeaderText = "Дата";
            this.DateIn.Name = "DateIn";
            this.DateIn.ReadOnly = true;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(6, 35);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(247, 20);
            this.NameTextbox.TabIndex = 1;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(465, 77);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // CountInputBox
            // 
            this.CountInputBox.Location = new System.Drawing.Point(3, 77);
            this.CountInputBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CountInputBox.Name = "CountInputBox";
            this.CountInputBox.Size = new System.Drawing.Size(70, 20);
            this.CountInputBox.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(484, 603);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "OK";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            // 
            // UpDownInPrice
            // 
            this.UpDownInPrice.Location = new System.Drawing.Point(186, 80);
            this.UpDownInPrice.Name = "UpDownInPrice";
            this.UpDownInPrice.Size = new System.Drawing.Size(67, 20);
            this.UpDownInPrice.TabIndex = 9;
            // 
            // groupBoxMeasure
            // 
            this.groupBoxMeasure.Controls.Add(this.RBInKgs);
            this.groupBoxMeasure.Controls.Add(this.RBInPcs);
            this.groupBoxMeasure.Location = new System.Drawing.Point(91, 61);
            this.groupBoxMeasure.Name = "groupBoxMeasure";
            this.groupBoxMeasure.Size = new System.Drawing.Size(67, 57);
            this.groupBoxMeasure.TabIndex = 10;
            this.groupBoxMeasure.TabStop = false;
            this.groupBoxMeasure.Text = "Ед. Изм.";
            // 
            // RBInKgs
            // 
            this.RBInKgs.AutoSize = true;
            this.RBInKgs.Location = new System.Drawing.Point(3, 39);
            this.RBInKgs.Name = "RBInKgs";
            this.RBInKgs.Size = new System.Drawing.Size(37, 17);
            this.RBInKgs.TabIndex = 1;
            this.RBInKgs.TabStop = true;
            this.RBInKgs.Text = "Кг";
            this.RBInKgs.UseVisualStyleBackColor = true;
            // 
            // RBInPcs
            // 
            this.RBInPcs.AutoSize = true;
            this.RBInPcs.Location = new System.Drawing.Point(3, 16);
            this.RBInPcs.Name = "RBInPcs";
            this.RBInPcs.Size = new System.Drawing.Size(42, 17);
            this.RBInPcs.TabIndex = 0;
            this.RBInPcs.TabStop = true;
            this.RBInPcs.Text = "Шт.";
            this.RBInPcs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AllowUserToAddRows = false;
            this.dataGridViewAll.AllowUserToDeleteRows = false;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewAll.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewAll.MultiSelect = false;
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAll.Size = new System.Drawing.Size(547, 139);
            this.dataGridViewAll.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ед Изм.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // selectOfAv
            // 
            this.selectOfAv.Location = new System.Drawing.Point(189, 18);
            this.selectOfAv.Name = "selectOfAv";
            this.selectOfAv.Size = new System.Drawing.Size(75, 23);
            this.selectOfAv.TabIndex = 12;
            this.selectOfAv.Text = "Выбор";
            this.selectOfAv.UseVisualStyleBackColor = true;
            this.selectOfAv.Click += new System.EventHandler(this.selectOfAv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Наименование";
            // 
            // labelOfAvIt
            // 
            this.labelOfAvIt.AutoSize = true;
            this.labelOfAvIt.Location = new System.Drawing.Point(6, 28);
            this.labelOfAvIt.Name = "labelOfAvIt";
            this.labelOfAvIt.Size = new System.Drawing.Size(41, 13);
            this.labelOfAvIt.TabIndex = 14;
            this.labelOfAvIt.Text = "(пусто)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество";
            // 
            // NumericAvPlus
            // 
            this.NumericAvPlus.Location = new System.Drawing.Point(9, 73);
            this.NumericAvPlus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericAvPlus.Name = "NumericAvPlus";
            this.NumericAvPlus.Size = new System.Drawing.Size(63, 20);
            this.NumericAvPlus.TabIndex = 16;
            // 
            // AddToExst
            // 
            this.AddToExst.Location = new System.Drawing.Point(189, 73);
            this.AddToExst.Name = "AddToExst";
            this.AddToExst.Size = new System.Drawing.Size(75, 23);
            this.AddToExst.TabIndex = 17;
            this.AddToExst.Text = "Добавить";
            this.AddToExst.UseVisualStyleBackColor = true;
            this.AddToExst.Click += new System.EventHandler(this.AddToExst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOfAvIt);
            this.groupBox1.Controls.Add(this.AddToExst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.selectOfAv);
            this.groupBox1.Controls.Add(this.NumericAvPlus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 116);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAll);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 286);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление позиций, которые есть в базе";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxMeasure);
            this.groupBox3.Controls.Add(this.UpDownInPrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CountInputBox);
            this.groupBox3.Controls.Add(this.AddNewButton);
            this.groupBox3.Controls.Add(this.NameTextbox);
            this.groupBox3.Location = new System.Drawing.Point(15, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 125);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление нового товара";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ItemsGridView);
            this.groupBox4.Location = new System.Drawing.Point(5, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 135);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поступление";
            // 
            // FormIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 629);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "FormIn";
            this.Text = "FormIn";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInPrice)).EndInit();
            this.groupBoxMeasure.ResumeLayout(false);
            this.groupBoxMeasure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAvPlus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDownInPrice;
        private System.Windows.Forms.GroupBox groupBoxMeasure;
        private System.Windows.Forms.RadioButton RBInKgs;
        private System.Windows.Forms.RadioButton RBInPcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button selectOfAv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOfAvIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumericAvPlus;
        private System.Windows.Forms.Button AddToExst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.NumericUpDown CountInputBox;
    }
}