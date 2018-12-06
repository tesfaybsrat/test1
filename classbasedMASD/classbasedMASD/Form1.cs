using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classbasedMASD
{
    public partial class AMDS : Form
    {
        Calculate cal = new Calculate();
        double dou_val1;
        double dou_val2;
        string v1, v2;
        public AMDS()
        {
            InitializeComponent();
        }

        public void Accc()
        {
            v1 = tBox1.Text;
            v2 = tBox2.Text;
            dou_val1 = double.Parse(v1);
            dou_val2 = double.Parse(v2);

            cal.numone = dou_val1;
            cal.numtwo = dou_val2;

            cal.n1 = double.Parse(tBox1.Text);
            cal.n2 = double.Parse(tBox2.Text);
        }
        private void AMDS_Load(object sender, EventArgs e)
        {
 
        }

        private void mul_Click(object sender, EventArgs e)
        {
            Accc();
            cal.mult();
            tBox3.Text = cal.result.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Accc();
            cal.subt();
            tBox3.Text = cal.result.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            Accc();
            cal.divi();
            // tBox3.Text = cal.result.ToString();
            tBox3.Text = cal.divi().ToString();
        }

        private void parameter_based_multiplication_Click(object sender, EventArgs e)
        {
           // cal.n1 = double.Parse(tBox1.Text);
           // cal.n2 = double.Parse(tBox2.Text);
            Accc();
            tBox3.Text=cal.parameter_based_mult(cal.n1, cal.n2).ToString();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Accc();
            cal.sum();
            tBox3.Text = cal.result.ToString();
        }
    }
}
