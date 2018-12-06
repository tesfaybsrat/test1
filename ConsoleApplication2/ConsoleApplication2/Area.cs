using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Area
    {
        private int area;
        private int length;
        private int width;
        public void Accept()
        {
            Console.WriteLine("Enter Width");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            length = Convert.ToInt32(Console.ReadLine());
        }

        public void cal()
        {
            area = width * length;
        }
        public void display()
        {
            Console.WriteLine("Area of length {0} and width of {0} ", length, width);
            Console.WriteLine(area);
        }
    }
}
