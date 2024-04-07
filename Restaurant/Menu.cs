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
    public partial class Menu : Form
    {
        public static Menu instance;
        private string day;
        public Label displayOrder;
        int totalofquantity = 0;
        double totalPrice = 0;

        public Menu(string day)
        {
            InitializeComponent();
            instance = this;
            this.day = day;
            displayOrder = space; 
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void quantity_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void txtorderyouchoose_TextChanged(object sender, EventArgs e)
        {

        }

        private void space_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Order = txtorderyouchoose.Text;
            int quantityOrder;

            double getprice = Mem3.GetPrice(Order, day);

            if (!int.TryParse(txtquantity.Text, out quantityOrder))
            {
                MessageBox.Show("Please enter a valid quantity.");

            }
            else if (quantityOrder < 0)
            {
                MessageBox.Show("Invalid quantity.");

            }
            if (getprice == 0)
            {
                MessageBox.Show("Item not found");

            }
            else
            {

                double priceofdisplay = Mem3.ComputeTotalPrice(quantityOrder, getprice);
                totalPrice += priceofdisplay;
                totalofquantity += quantityOrder;
                txtprice.Text = priceofdisplay.ToString();

            }
        }

        private void txtCalculateyourorder_Click(object sender, EventArgs e)
        {
            double discount = Mem3.discount(totalofquantity, totalPrice);
            double pricetotal = Mem3.discounted(totalPrice, discount);
            txttotalprice.Text = pricetotal.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttotalprice.Text = string.Empty;
            txtquantity.Text = string.Empty;    
            txtprice.Text = string.Empty;
            txtorderyouchoose.Text = string.Empty;
            totalPrice = 0;
            totalofquantity = 0;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
