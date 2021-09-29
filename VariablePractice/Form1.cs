using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        { int pnumber = 99;
            outputLabel.Text = $"the number of the hockey player wayne gretzky is {pnumber}";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;
            outputLabel.Text = $"you worked for {hours} with an hourly wage of {pay} your pay is {earned}";
        }

        private void area_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pie = 3.14;
            double answer = radius * radius * pie;

            outputLabel.Text = $"the circle with a radius of {radius} times {pie} equals {answer}";
        }

        private void carpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
                double width = 6;
                double costpermeter = 19.95;
            double area = length * width;
            double cost = area * costpermeter;
            outputLabel.Text = $"to carpet the room that has thw width of {width}m and the length of {length}m plus the cost of every square meter being {costpermeter} your total is {cost}.";
        }

        private void bill_Click(object sender, EventArgs e)
        {
            double shirtcost = 12.49;
            double bill = 20;
            double tax = 0.13;
            double subtotal = shirtcost * tax + shirtcost;
            double compleatetotal = bill - subtotal;
            outputLabel.Text = $"shirt cost ${shirtcost} \n tax: ${tax} \n total is: ${subtotal} \n your change is ${compleatetotal} have a nice day";
        }
    }
}
