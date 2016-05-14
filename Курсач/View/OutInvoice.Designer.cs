namespace Курсач
{
    partial class OutInvoice
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
            this.InvoiceOkButton = new System.Windows.Forms.Button();
            this.InvoiceCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 134);
            this.listBox1.TabIndex = 0;
            // 
            // InvoiceOkButton
            // 
            this.InvoiceOkButton.Location = new System.Drawing.Point(197, 171);
            this.InvoiceOkButton.Name = "InvoiceOkButton";
            this.InvoiceOkButton.Size = new System.Drawing.Size(75, 23);
            this.InvoiceOkButton.TabIndex = 1;
            this.InvoiceOkButton.Text = "Ok";
            this.InvoiceOkButton.UseVisualStyleBackColor = true;
            // 
            // InvoiceCancelButton
            // 
            this.InvoiceCancelButton.Location = new System.Drawing.Point(116, 171);
            this.InvoiceCancelButton.Name = "InvoiceCancelButton";
            this.InvoiceCancelButton.Size = new System.Drawing.Size(75, 23);
            this.InvoiceCancelButton.TabIndex = 2;
            this.InvoiceCancelButton.Text = "Cancel";
            this.InvoiceCancelButton.UseVisualStyleBackColor = true;
            // 
            // OutInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.InvoiceCancelButton);
            this.Controls.Add(this.InvoiceOkButton);
            this.Controls.Add(this.listBox1);
            this.Name = "OutInvoice";
            this.Text = "OutInvoice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button InvoiceOkButton;
        private System.Windows.Forms.Button InvoiceCancelButton;
    }
}