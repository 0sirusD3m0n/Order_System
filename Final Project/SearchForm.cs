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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            int orderNum;
            if (int.TryParse(searchTB.Text, out orderNum))
            {
                if (orderNum > OrderSys.OrderNumber())
                {
                    MessageBox.Show("Order number " + orderNum + " does not exist. Please try again");
                }
                else
                {
                    // add decision tree to determin which load order is called. Sub or Hamburger
                    if (OrderSys.isBurger(orderNum))
                    {
                        Hamburger order = OrderSys.LoadBurgerOrder(orderNum);

                        ResultsForm results = new ResultsForm(order, orderNum);

                        results.ShowDialog();
                    }
                    else if (!OrderSys.isBurger(orderNum))
                    {
                        Sub order = OrderSys.LoadSubOrder(orderNum);

                        ResultsForm results = new ResultsForm(order, orderNum);

                        results.ShowDialog();
                    }
                }
                
            }

        }
    }
}
