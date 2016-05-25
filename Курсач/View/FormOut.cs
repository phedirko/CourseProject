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

        public List<Item> items = new List<Item>();
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




        public void ThrowItemToOut(DataGridView dataGridViewAv)
        {
            var c = dataGridViewAv.SelectedRows;



            string name1 = c[0].Cells[0].Value.ToString();
            double count1 = (double)numericUpDownToOut.Value;
            string measure1 = c[0].Cells[2].Value.ToString();
            double price1 = double.Parse(c[0].Cells[3].Value.ToString());
            DateTime dateOfLast1 = Convert.ToDateTime(c[0].Cells[4].Value.ToString());

            double realCount = double.Parse(c[0].Cells[1].Value.ToString());

            if (realCount < count1) MessageBox.Show("Нет такого количества");
            else
            {
                //Удаление из DataGridView в наличии
                foreach (DataGridViewRow item in this.dataGridViewAv.SelectedRows)
                {
                    dataGridViewAv.Rows.RemoveAt(item.Index);
                }

                // Создание нового товара на выход. По сути, не нужно
                Item itemToOut = new Item()
                {
                    Name = c[0].Cells[0].Value.ToString(),
                    Count = count1,
                    Measure = c[0].Cells[2].Value.ToString(),
                    Price = double.Parse(c[0].Cells[3].Value.ToString()),
                    dateOfLast = Convert.ToDateTime(c[0].Cells[4].Value.ToString()),

                };

                string[] row = new string[]
                {
                itemToOut.Name,
                itemToOut.Count.ToString(),
                itemToOut.Measure,
                itemToOut.Price.ToString(),
                itemToOut.TotalPrice().ToString(),
                };

                dataGridView1.Rows.Add(row);


                foreach (Item i in GlobalItemsOut.items)
                {
                    if (i.Name == name1) i.Count -= count1;
                }
            }

        }
        


        private void MinusItem_Click(object sender, EventArgs e)
        {
            ThrowItemToOut(dataGridViewAv);           
        }

        private void PlusItem_Click(object sender, EventArgs e)
        {

            labelName.Text = dataGridViewAv.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void OkItem_Click(object sender, EventArgs e)
        {
            GlobalItemsOut.Add(items);
            this.Close();
        }

        private void FormOut_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewToOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
    }
}
