using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Size = new Size(535, 251);
            orderForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();

            search.ShowDialog();
        }
    }
}
