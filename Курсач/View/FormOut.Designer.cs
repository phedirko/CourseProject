namespace Курсач
{
    partial class FormOut
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
            this.AddToOutBtn = new System.Windows.Forms.Button();
            this.SelectItemBtn = new System.Windows.Forms.Button();
            this.OkItem = new System.Windows.Forms.Button();
            this.dataGridViewAv = new System.Windows.Forms.DataGridView();
            this.NameOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameToOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountToOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureToOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceToOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownToOut = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToOut)).BeginInit();
            this.SuspendLayout();
            // 
            // AddToOutBtn
            // 
            this.AddToOutBtn.Location = new System.Drawing.Point(289, 236);
            this.AddToOutBtn.Name = "AddToOutBtn";
            this.AddToOutBtn.Size = new System.Drawing.Size(75, 23);
            this.AddToOutBtn.TabIndex = 7;
            this.AddToOutBtn.Text = "Добавить";
            this.AddToOutBtn.UseVisualStyleBackColor = true;
            this.AddToOutBtn.Click += new System.EventHandler(this.MinusItem_Click);
            // 
            // SelectItemBtn
            // 
            this.SelectItemBtn.Location = new System.Drawing.Point(289, 160);
            this.SelectItemBtn.Name = "SelectItemBtn";
            this.SelectItemBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectItemBtn.TabIndex = 8;
            this.SelectItemBtn.Text = "Выбор";
            this.SelectItemBtn.UseVisualStyleBackColor = true;
            this.SelectItemBtn.Click += new System.EventHandler(this.PlusItem_Click);
            // 
            // OkItem
            // 
            this.OkItem.Location = new System.Drawing.Point(457, 466);
            this.OkItem.Name = "OkItem";
            this.OkItem.Size = new System.Drawing.Size(75, 23);
            this.OkItem.TabIndex = 9;
            this.OkItem.Text = "OK";
            this.OkItem.UseVisualStyleBackColor = true;
            this.OkItem.Click += new System.EventHandler(this.OkItem_Click);
            // 
            // dataGridViewAv
            // 
            this.dataGridViewAv.AllowUserToAddRows = false;
            this.dataGridViewAv.AllowUserToDeleteRows = false;
            this.dataGridViewAv.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridViewAv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfItem,
            this.Count,
            this.Mesure,
            this.Price,
            this.DateOfLast});
            this.dataGridViewAv.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewAv.MultiSelect = false;
            this.dataGridViewAv.Name = "dataGridViewAv";
            this.dataGridViewAv.ReadOnly = true;
            this.dataGridViewAv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAv.Size = new System.Drawing.Size(519, 141);
            this.dataGridViewAv.TabIndex = 10;
           
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameToOut,
            this.CountToOut,
            this.MeasureToOut,
            this.PriceToOut,
            this.AvPr});
            this.dataGridView1.Location = new System.Drawing.Point(13, 291);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(519, 150);
            this.dataGridView1.TabIndex = 11;
            
            // 
            // NameToOut
            // 
            this.NameToOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameToOut.HeaderText = "Name";
            this.NameToOut.Name = "NameToOut";
            this.NameToOut.ReadOnly = true;
            // 
            // CountToOut
            // 
            this.CountToOut.HeaderText = "Count";
            this.CountToOut.Name = "CountToOut";
            this.CountToOut.ReadOnly = true;
            // 
            // MeasureToOut
            // 
            this.MeasureToOut.HeaderText = "Measure";
            this.MeasureToOut.Name = "MeasureToOut";
            this.MeasureToOut.ReadOnly = true;
            // 
            // PriceToOut
            // 
            this.PriceToOut.HeaderText = "Price";
            this.PriceToOut.Name = "PriceToOut";
            this.PriceToOut.ReadOnly = true;
            // 
            // AvPr
            // 
            this.AvPr.HeaderText = "AverPrice";
            this.AvPr.Name = "AvPr";
            this.AvPr.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(13, 190);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(183, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество";
            // 
            // numericUpDownToOut
            // 
            this.numericUpDownToOut.Location = new System.Drawing.Point(186, 183);
            this.numericUpDownToOut.Name = "numericUpDownToOut";
            this.numericUpDownToOut.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownToOut.TabIndex = 15;
            // 
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 501);
            this.Controls.Add(this.numericUpDownToOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewAv);
            this.Controls.Add(this.OkItem);
            this.Controls.Add(this.SelectItemBtn);
            this.Controls.Add(this.AddToOutBtn);
            this.Name = "FormOut";
            this.Text = "FormOut";
            this.Load += new System.EventHandler(this.FormOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddToOutBtn;
        private System.Windows.Forms.Button SelectItemBtn;
        private System.Windows.Forms.Button OkItem;
        private System.Windows.Forms.DataGridView dataGridViewAv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameToOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountToOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureToOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceToOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownToOut;
    }
}