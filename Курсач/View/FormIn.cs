using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.View
{
    public partial class FormIn : Form
    {
        public List<Item> items = new List<Item>();

        public ItemCollection GlobalItems;


        public FormIn(ItemCollection globalItems)
        {
            GlobalItems = globalItems;
            InitializeComponent();
            RefreshDataView(null,null);
        }


        public void RefreshDataView(object sender, EventArgs e)
        {
            dataGridViewAll.Rows.Clear();
            foreach (Item i in GlobalItems.items)
            {
                string[] row = new string[]
                {
                    i.Name.ToString(),
                    i.Count.ToString(),
                    i.Measure.ToString(),
                    i.Price.ToString(),
                    i.dateOfLast.ToString(),

                };

                dataGridViewAll.Rows.Add(row);
            }
        }



        public void AvPlus(string name, double number)
        {
            foreach(Item i in GlobalItems.items)
            {
                if (i.Name == name)
                {
                    i.Count += number;
                    i.dateOfLast = DateTime.Now;
                }
            }
        }


        //Добавление нового
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            double price = (double)UpDownInPrice.Value;
            double count = (double)CountInputBox.Value;
            string measure;
            DateTime dat = DateTime.Now;

            if (RBInKgs.Checked) measure = "Кг.";
            else measure = "Шт.";


                Item newItem = new Item() {
                    Name = name,
                    Count = count,
                    dateOfLast = dat,
                    Measure = measure,
                    Price = price


                };
            items.Add(newItem);

            ItemsGridView.Rows.Add(
                new string[] {
                    name,
                    count.ToString(),
                    measure,
                    price.ToString(),
                    dat.ToString()

                });

           
        }

       

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            GlobalItems.Add(items);
            this.Close();
        }

        private void selectOfAv_Click(object sender, EventArgs e)
        {
            var sIt = dataGridViewAll.SelectedRows;
            var nameOfSel = sIt[0].Cells[0].Value.ToString();
            labelOfAvIt.Text = nameOfSel;
                        
        }


        private void AddToExst_Click(object sender, EventArgs e)
        {
            var sIt = dataGridViewAll.SelectedRows;
            var numb = (double)NumericAvPlus.Value;
            var nameOfSel = sIt[0].Cells[0].Value.ToString();
            AvPlus(nameOfSel, numb);

            ItemsGridView.Rows.Add(
               new string[] 
                {
                    sIt[0].Cells[0].Value.ToString(),
                    numb.ToString(),
                    sIt[0].Cells[2].Value.ToString(),
                    sIt[0].Cells[3].Value.ToString(),
                    DateTime.Now.ToString()
                });
        }
    }
}
