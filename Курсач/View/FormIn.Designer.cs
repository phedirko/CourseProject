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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.CountInputBox = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDownInPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMeasure = new System.Windows.Forms.GroupBox();
            this.RBInPcs = new System.Windows.Forms.RadioButton();
            this.RBInKgs = new System.Windows.Forms.RadioButton();
            this.NameIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInPrice)).BeginInit();
            this.groupBoxMeasure.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameIn,
            this.Count,
            this.MeasureType,
            this.Price,
            this.DateIn});
            this.ItemsGridView.Location = new System.Drawing.Point(12, 12);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.Size = new System.Drawing.Size(547, 169);
            this.ItemsGridView.TabIndex = 0;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(12, 221);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(247, 20);
            this.NameTextbox.TabIndex = 1;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(184, 396);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Add";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // CountInputBox
            // 
            this.CountInputBox.Location = new System.Drawing.Point(12, 269);
            this.CountInputBox.Name = "CountInputBox";
            this.CountInputBox.Size = new System.Drawing.Size(70, 20);
            this.CountInputBox.TabIndex = 4;
            this.CountInputBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(479, 396);
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
            this.label1.Location = new System.Drawing.Point(9, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            // 
            // UpDownInPrice
            // 
            this.UpDownInPrice.Location = new System.Drawing.Point(12, 319);
            this.UpDownInPrice.Name = "UpDownInPrice";
            this.UpDownInPrice.Size = new System.Drawing.Size(67, 20);
            this.UpDownInPrice.TabIndex = 9;
            // 
            // groupBoxMeasure
            // 
            this.groupBoxMeasure.Controls.Add(this.RBInKgs);
            this.groupBoxMeasure.Controls.Add(this.RBInPcs);
            this.groupBoxMeasure.Location = new System.Drawing.Point(12, 356);
            this.groupBoxMeasure.Name = "groupBoxMeasure";
            this.groupBoxMeasure.Size = new System.Drawing.Size(67, 57);
            this.groupBoxMeasure.TabIndex = 10;
            this.groupBoxMeasure.TabStop = false;
            this.groupBoxMeasure.Text = "Ед. Изм.";
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
            // NameIn
            // 
            this.NameIn.HeaderText = "Наименование";
            this.NameIn.Name = "NameIn";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // MeasureType
            // 
            this.MeasureType.HeaderText = "Ед Изм.";
            this.MeasureType.Name = "MeasureType";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // DateIn
            // 
            this.DateIn.HeaderText = "Дата";
            this.DateIn.Name = "DateIn";
            // 
            // FormIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 425);
            this.Controls.Add(this.groupBoxMeasure);
            this.Controls.Add(this.UpDownInPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CountInputBox);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.ItemsGridView);
            this.Name = "FormIn";
            this.Text = "FormIn";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInPrice)).EndInit();
            this.groupBoxMeasure.ResumeLayout(false);
            this.groupBoxMeasure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.NumericUpDown CountInputBox;
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
    }
}