using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularApplication
{
    class Rectangle{
    //members
    double width;
    double height;
    public void Acceptdtails()
    {
        width = 10.8;
        height = 5.5;
    }
    public double Area(){
        return width* height;
   }
   public void Display()
    {
        Console.WriteLine("width ", width);
        Console.WriteLine("height {0}", height);
        Console.WriteLine("Area {0}", Area());

    }
}
    class Excuterecrangle
    {
        static void Main(string[] args)
        {
        Rectangle r = new Rectangle();
        r.Acceptdtails();
        r.Area();
        r.Display();
        Console.ReadKey();
        }
    }
}
