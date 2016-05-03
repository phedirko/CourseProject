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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MinusItem = new System.Windows.Forms.Button();
            this.PlusItem = new System.Windows.Forms.Button();
            this.OkItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 160);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 194);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(499, 95);
            this.listBox2.TabIndex = 5;
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
            // FormOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.OkItem);
            this.Controls.Add(this.PlusItem);
            this.Controls.Add(this.MinusItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "FormOut";
            this.Text = "FormOut";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button MinusItem;
        private System.Windows.Forms.Button PlusItem;
        private System.Windows.Forms.Button OkItem;
    }
}