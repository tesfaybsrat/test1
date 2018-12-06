using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        string Opration = "";
        bool opration_proccess = false;
        double value;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || opration_proccess)
                result.Text = " ";
            opration_proccess = false;
            //result.Text = result.Text + "7";
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void Opration_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Opration = b.Text;
            value = double.Parse(result.Text);
            opration_proccess = true;
            Equation.Text = value +" " + Opration;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Equation.Text = "";
            switch (Opration)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;

            }
            //opration_proccess = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
