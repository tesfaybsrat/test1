using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            maths sum = new maths();
            sum.val1 = tBox1.Text;
            sum.val2 = tBox2.Text;
            //sum.val3 = tBox3.Text;
            sum.val3 = sum.val1 + sum.val2;
            tBox3.Text = sum.val3;

        }

        private void mult_Click(object sender, EventArgs e)
        {
            maths sum = new maths();
            sum.val1 = tBox1.Text;
            sum.val2 = tBox2.Text;
            //sum.val3 = tBox3.Text;
            sum.val3 = sum.val1 + sum.val2;
            tBox3.Text = sum.val3;
        }
    }
}
