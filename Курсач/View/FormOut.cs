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

        public List<Item> itemsOut = new List<Item>();
        public ItemCollection GlobalItemsOut;

        public FormOut(ItemCollection globalItemsOut)
        {
            GlobalItemsOut = globalItemsOut;
            InitializeComponent();
            RefreshDataAv(null, null);
        }


        public void RefreshDataAv(object sender, EventArgs e)
        {
            dataGridViewAv.Rows.Clear();
            foreach (Item i in GlobalItemsOut.items)
            {
                string[] row = new string[]
                {
                    i.Name.ToString(),
                    i.Count.ToString(),
                    i.Measure.ToString(),
                    i.Price.ToString(),
                    i.dateOfLast.ToString(),

                };

                dataGridViewAv.Rows.Add(row);
            }
        }

       



        


        private void MinusItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PlusItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewAv.SelectedRows)
            {
                dataGridViewAv.Rows.RemoveAt(item.Index);
            }
            FormOutConfirm newConf = new FormOutConfirm();
            newConf.ShowDialog();
            
        }

        private void OkItem_Click(object sender, EventArgs e)
        {
            OutInvoice newInvoice = new OutInvoice();
            newInvoice.Show();
        }

        private void FormOut_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewAv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
