using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class profile
    {
        private string fname;
        private string lname;
        private int age;

        public void acc()
        {
            Console.WriteLine("Your name :");
            fname = Console.ReadLine();
            Console.WriteLine("Father name :");
            lname = Console.ReadLine();
        }
        
        public void display()
        {
            Console.WriteLine("Full Name : {0} {0}", fname, lname);
        }
    }
}
