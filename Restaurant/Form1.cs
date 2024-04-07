using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{

    public partial class Form1 : Form
    {
        public static Form1 form;
            private string day;
        private TextBox tb; 
        public Form1()
        {
            InitializeComponent();
            form = this;
            tb = tbt2;
           
        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string day = tbt2.Text;
            string menuDay = Mem3.DisplayMenu(day);

            if (menuDay == "")
            {
                MessageBox.Show("Invalid Day Enter");
            }
            else if (menuDay == "Linggo" || menuDay == "linggo")
            {
                Mem3.DisplayMenu(day);
            }
            else
            {
                Menu menu = new Menu(day);
                menu.Show();
                menu.displayOrder.Text = menuDay;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)

        {
            }

        private void enter_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


