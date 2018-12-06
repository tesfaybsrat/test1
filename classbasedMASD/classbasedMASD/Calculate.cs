using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classbasedMASD
{
    class Calculate
    {
        // class variables
        private double num1;
        private double num2;
        private double num3;

        public double n1, n2;

        public double parameter_based_mult(double n1, double n2){
            return (n1 * n2);
            }

        // class preporties
        public double result
        {
            get
            {
                return num3;
            }
        }
        public double numone
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        public double numtwo
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }



//methods
    public void sum()
        {
             num3 = num1 + num2;
        }
   
   public void mult()
        {
             num3 = num1 * num2;
        }

   public void subt()
        {
             num3 = num1 - num2;
        }

   public double divi()
        {
            if (num2 == 0)
                return 0;
            else
             return (num1 / num2);
        }
    }
}
