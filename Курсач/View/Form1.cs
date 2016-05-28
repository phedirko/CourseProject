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


        //Обвноление таблицы товаров главной формы
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

       
        //Открытие формы отгрузки 
        private void button2_Click(object sender, EventArgs e)
        {
            FormOut newForm = new FormOut(itc);
            newForm.Show();
            newForm.FormClosed += RefreshDataView;
        }

        //Открытие формы поступления
        private void button1_Click_1(object sender, EventArgs e)
        {
            FormIn NewForm = new FormIn(itc);
            NewForm.Show();
            NewForm.FormClosed += RefreshDataView;
        }


        //Удаление товара из базы
        private void button3_Click_1(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Вы действительно хотите удалить этот товар из базы?",
                                     "Подтверждение удаления",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string toDel = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Item i in itc.items)
                {
                    if (i.Name == toDel)
                    {
                        itc.items.Remove(i);
                        break;
                    }

                }
                RefreshDataView(null, null);
            }
        }

    }
}
