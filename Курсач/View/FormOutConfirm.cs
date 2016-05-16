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
    public partial class FormOutConfirm : Form
    {
        public FormOutConfirm()
        {
            Item itd = new Item()
            {
                Name = "ff",
                Price = 3,
                Count = 10,
                Measure = "fr",
                dateOfLast = DateTime.Now
            };
            InitializeComponent();
            textBoxOutConf.Text = itd.ToString();
            
        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormOutConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
