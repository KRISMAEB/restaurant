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

        public Menu(string day)
        {
            InitializeComponent();
            instance = this;
            this.day = day;
            displayOrder = displaythemenu;

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {

        }
    }
}