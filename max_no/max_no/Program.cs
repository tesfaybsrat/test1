using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_no
{
    class max_check
    {
        public void comper(double num1, double num2)
        {
            if (num1 > num2)
                Console.WriteLine("the maximam no of"+ num1 + " and "+ num2+" is " + num1);
            else if(num2 > num1)
                Console.WriteLine("the maximam no of" + num1 + " and " + num2 + " is " + num2);
            else
                Console.WriteLine("they are equal " + num1 + " and " + num2);
        }

        public double comperrrr(double num1, double num2)
        {
            if (num1 > num2)
                return num1;
            else if (num2 > num1)
                return num2;
            else

                return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            max_check max = new max_check();
            max.comper(n1, n2);
            double e= max.comperrrr(n1,n2);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
