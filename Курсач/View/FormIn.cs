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
        }

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            GlobalItems.Add(items);
            this.Close();
        }

        
    }
}
