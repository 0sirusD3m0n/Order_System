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
    public partial class ResultsForm : Form
    {
        

        public ResultsForm(Hamburger iOrder, int orderNum)
        {
            InitializeComponent();

            this.Text = "Order: " + orderNum.ToString();
            burgerPanel.Visible = true;

            if (iOrder != null)
            {
                hName.Text = iOrder.name;
                hSize.Text = iOrder.meat;
                hCheese.Text = iOrder.cheese;
                hLettuce.Text = iOrder.lettuce.ToString();
                hTomato.Text = iOrder.tomato.ToString();
                hOnion.Text = iOrder.onion.ToString();
                hBacon.Text = iOrder.bacon.ToString();
                hKetchup.Text = iOrder.ketchup.ToString();
                hMustard.Text = iOrder.mustard.ToString();
                hMayo.Text = iOrder.mayo.ToString();
            }
            else
            {
                MessageBox.Show("Not a valid order number");
            }   
        }

        public ResultsForm(Sub iOrder, int orderNum)
        {
            InitializeComponent();

            this.Text = "Order: " + orderNum.ToString();
            subPanel.Visible = true;

            if (iOrder != null)
            {
                sName.Text = iOrder.name;
                sMeat.Text = iOrder.meat;
                sCheese.Text = iOrder.cheese;
                sLettuce.Text = iOrder.lettuce.ToString();
                sPickle.Text = iOrder.pickle.ToString();
                sTomato.Text = iOrder.tomato.ToString();
                sOnion.Text = iOrder.onion.ToString();
                sMayo.Text = iOrder.mayo.ToString();
                sMustard.Text = iOrder.mustard.ToString();
                sVin.Text = iOrder.vinaigrette.ToString();
            }
            else
            {
                MessageBox.Show("Not a valid order number");
            }
        }

        public ResultsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
