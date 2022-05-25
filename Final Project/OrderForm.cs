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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void hamburgerButton_CheckedChanged(object sender, EventArgs e)
        {
            // sets display to show hamburger order form
            if (hamburgerButton.Checked)
            {
                this.Size = new Size(505, 490);
                if (subPanel.Visible)
                {
                    subPanel.Visible = false;
                }
                hamburgerPanel.Visible = true;
                saveCancelPanel.Visible = true;

                
            }
        }

        private void subButton_CheckedChanged(object sender, EventArgs e)
        {
            //sets sub panel to be visible
            if (subButton.Checked)
            {
                this.Size = new Size(505, 490);
                if (hamburgerPanel.Visible)
                {
                    hamburgerPanel.Visible = false;
                }
                subPanel.Visible = true;
                saveCancelPanel.Visible = true;

                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // this function code probably needs a rewrite, and I haven't even written it yet. Look into it later to see if nested ifs are the best way about it.
        private void saveButton_Click(object sender, EventArgs e) 
        {
            // create local variables
            string name, meat, cheese;
            name = meat = cheese = "";
            char bacon, lettuce, tomato, onion, mustard, mayo, ketchup, pickle, vinaigrette;
            bacon = lettuce = tomato = onion = mustard = mayo = ketchup = vinaigrette = pickle = 'N';



            // check for options selected, and save to new object. Object them passed to OrderSys class to save.
            if (hamburgerButton.Checked)
            {

                name = hNameTB.Text;
                if (meatSelection.SelectedItem != null)
                {
                    meat = meatSelection.SelectedItem.ToString();
                }

                if (hCheeseCB.SelectedItem != null) 
                cheese = hCheeseCB.SelectedItem.ToString();
                
                if (toppingsList.GetItemChecked(0))
                {
                    bacon = 'Y';
                }
               

                if (toppingsList.GetItemChecked(1))
                {
                    lettuce = 'Y';
                }
                

                if (toppingsList.GetItemChecked(2))
                {
                    tomato = 'Y';
                }

                if (toppingsList.GetItemChecked(3))
                {
                    onion = 'Y';
                }

                if (condomentsLB.GetItemChecked(0))
                {
                    ketchup = 'Y';
                }

                if (condomentsLB.GetItemChecked(1))
                {
                    mustard = 'Y';
                }
               
                if (condomentsLB.GetItemChecked(2))
                {
                    mayo = 'Y';
                }

                Hamburger burger = new Hamburger(name, meat, cheese, lettuce, tomato, onion, bacon, ketchup, mustard, mayo);

                OrderSys.SaveOrder(burger);
            }

            // check for options selected, and save to new object. Object them passed to OrderSys class to save.
            if (subButton.Checked)
            {

                name = sNameTB.Text;
                if (meatSelectCB.SelectedItem != null)
                {
                    meat = meatSelectCB.SelectedItem.ToString();
                }

                if (sCheeseCB.SelectedItem != null)
                    cheese = sCheeseCB.SelectedItem.ToString();

                if (sLB.GetItemChecked(0))
                {
                    lettuce = 'Y';
                }


                if (sLB.GetItemChecked(1))
                {
                    tomato = 'Y';
                }


                if (sLB.GetItemChecked(2))
                {
                    onion = 'Y';
                }

                if (sLB.GetItemChecked(3))
                {
                    pickle = 'Y';
                }

                if (sCondimentsLB.GetItemChecked(0))
                {
                    mayo = 'Y';
                }

                if (sCondimentsLB.GetItemChecked(1))
                {
                    mustard = 'Y';
                }

                if (sCondimentsLB.GetItemChecked(2))
                {
                    vinaigrette = 'Y';
                }

                Sub sub = new Sub(name, meat, cheese, lettuce, tomato, onion, pickle, mayo, mustard, vinaigrette);

                OrderSys.SaveOrder(sub);
            }
            this.Close();
        }
    }
}
