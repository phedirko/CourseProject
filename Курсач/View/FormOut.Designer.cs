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
            this.listBoxOut = new System.Windows.Forms.ListBox();
            this.MinusItem = new System.Windows.Forms.Button();
            this.PlusItem = new System.Windows.Forms.Button();
            this.OkItem = new System.Windows.Forms.Button();
            this.dataGridViewAv = new System.Windows.Forms.DataGridView();
            this.NameOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAv)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOut
            // 
            this.listBoxOut.FormattingEnabled = true;
            this.listBoxOut.Location = new System.Drawing.Point(13, 194);
            this.listBoxOut.Name = "listBoxOut";
            this.listBoxOut.Size = new System.Drawing.Size(519, 95);
            this.listBoxOut.TabIndex = 5;
            // 
            // MinusItem
            // 
            this.MinusItem.Location = new System.Drawing.Point(356, 341);
            this.MinusItem.Name = "MinusItem";
            this.MinusItem.Size = new System.Drawing.Size(75, 23);
            this.MinusItem.TabIndex = 7;
            this.MinusItem.Text = "-";
            this.MinusItem.UseVisualStyleBackColor = true;
            this.MinusItem.Click += new System.EventHandler(this.MinusItem_Click);
            // 
            // PlusItem
            // 
            this.PlusItem.Location = new System.Drawing.Point(437, 341);
            this.PlusItem.Name = "PlusItem";
            this.PlusItem.Size = new System.Drawing.Size(75, 23);
            this.PlusItem.TabIndex = 8;
            this.PlusItem.Text = "+";
            this.PlusItem.UseVisualStyleBackColor = true;
            this.PlusItem.Click += new System.EventHandler(this.PlusItem_Click);
            // 
            // OkItem
            // 
            this.OkItem.Location = new System.Drawing.Point(13, 341);
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
            this.dataGridViewAv.Size = new System.Drawing.Size(519, 126);
            this.dataGridViewAv.TabIndex = 10;
            this.dataGridViewAv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAv_CellContentClick);
            // 
            // NameOfItem
            // 
            this.NameOfItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameOfItem.HeaderText = "Наименование";
            this.NameOfItem.Name = "NameOfItem";
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // Mesure
            // 
            this.Mesure.HeaderText = "Ед. Изм";
            this.Mesure.Name = "Mesure";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // DateOfLast
            // 
            this.DateOfLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfLast.HeaderText = "Дата";
            this.DateOfLast.Name = "DateOfLast";
            // 
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.dataGridViewAv);
            this.Controls.Add(this.OkItem);
            this.Controls.Add(this.PlusItem);
            this.Controls.Add(this.MinusItem);
            this.Controls.Add(this.listBoxOut);
            this.Name = "FormOut";
            this.Text = "FormOut";
            this.Load += new System.EventHandler(this.FormOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxOut;
        private System.Windows.Forms.Button MinusItem;
        private System.Windows.Forms.Button PlusItem;
        private System.Windows.Forms.Button OkItem;
        private System.Windows.Forms.DataGridView dataGridViewAv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLast;
    }
}