using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_calclulator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            const int PIZZA_PRICE = 7;
            const double Tax = 1.13;
            double price, numOfToppings, costOfToppings;
            numOfToppings = 0;

            try
            {
                numOfToppings = Convert.ToDouble(NumberOfToppings.Text);
            }
            catch
            {
                OutPutLabel.Text = "Please enter a numeric value for the number of toppings";
                return;
            }
            costOfToppings = 1.25 * numOfToppings;
            price = PIZZA_PRICE + costOfToppings;

            OutPutLabel.Text = "The Price of a pizza with " + numOfToppings + " Toppings is: $" + price;

        }
    }
}
