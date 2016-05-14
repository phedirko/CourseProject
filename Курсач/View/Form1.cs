using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.View;

namespace Курсач
{
    public partial class Form1 : Form
    {
        //Создание объекта коллекции
        public ItemCollection itc = new ItemCollection();

        //Главная форма 
        public Form1(ItemCollection items)
        {
            itc = items;
            InitializeComponent();
            RefreshDataView(null, null);
        }



        


        public void RefreshDataView(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Item i in itc.items)
            {
                string[] row = new string[]
                {
                    i.Name.ToString(),
                    i.Count.ToString(),
                    i.Measure.ToString(),
                    i.Price.ToString(),
                    i.dateOfLast.ToString(),

                };

                dataGridView1.Rows.Add(row);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Item<int> item1 = new Item<int>();
            //item1.Set(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOut newForm = new FormOut();
            newForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormIn NewForm = new FormIn(itc);
            NewForm.Show();

            NewForm.FormClosed += RefreshDataView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itc.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            itc.Load();
        }
    }
}
