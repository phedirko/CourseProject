using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        // Обновление таблицы товаров в наличии на форме отгрузки
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

        // Метод, который увеличивает значение "количество"
        // у выбранного товара, который есть в базе
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
        

        //Добавление нового товара
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

        // Метод экспорта в тхт
        public void ExportToTXT()
        {
                     
            string filename = String.Format("Поступление{0:yyyy-MM-dd-HH-mm}{1}", DateTime.Now, ".txt");
            TextWriter sw = new StreamWriter(@filename);
            int rowcount = ItemsGridView.Rows.Count;

            double avpr=0;
            sw.WriteLine("Наим\tКол-во\tЦена\tСумма");
            for (int i = 0; i < rowcount; i++)
            {
                var itogo = double.Parse(ItemsGridView.Rows[i].Cells[1].Value.ToString()) * 
                    double.Parse(ItemsGridView.Rows[i].Cells[3].Value.ToString());
                avpr += itogo;
                sw.WriteLine(
                    ItemsGridView.Rows[i].Cells[0].Value.ToString() + "\t"
                    + ItemsGridView.Rows[i].Cells[1].Value.ToString() + " "
                    + ItemsGridView.Rows[i].Cells[2].Value.ToString() + "\t"
                    + ItemsGridView.Rows[i].Cells[3].Value.ToString() + "\t"
                    + itogo

                    );
            }

            sw.WriteLine("\nИтого:" + avpr);
            sw.Close();
        }
        


        // Добавление новых товаров в коллекцию по нажатию кнопки ОК
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            GlobalItems.Add(items);
            ExportToTXT();          
            this.Close();
        }

        // Метод, который выводит имя выбранного товара
        private void selectOfAv_Click(object sender, EventArgs e)
        {
            var sIt = dataGridViewAll.SelectedRows;
            var nameOfSel = sIt[0].Cells[0].Value.ToString();
            labelOfAvIt.Text = nameOfSel;                        
        }

        // Добавляет товар в таблицу поступления
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
