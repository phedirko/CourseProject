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
            double count = (double)CountInputBox.Value;

            Item newItem = new Item() {
                Name = name,
                Count = count,
                dateOfLast = DateTime.Now,
                Measure = "kgs",
                Price = 100500
                

            };
            items.Add(newItem);

            ItemsGridView.Rows.Add(
                new string[] {
                    name,
                    count.ToString()
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
