using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class FormOut : Form
    {
        public FormOut()
        {
            InitializeComponent();
        }



        private void MinusItem_Click(object sender, EventArgs e)
        {
            FormOutConfirm newConf = new FormOutConfirm();
            newConf.Show();
        }

        private void PlusItem_Click(object sender, EventArgs e)
        {
            
        }

        private void OkItem_Click(object sender, EventArgs e)
        {
            OutInvoice newInvoice = new OutInvoice();
            newInvoice.Show();
        }
    }
}
