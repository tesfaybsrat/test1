using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateEX1
{
    public delegate int NumberChanger(int n);
    class Program
    {
        static int num = 10;

        static int Addnum(int p)
        {
            num += p;
            return num;
        }
        static int Multnum(int q)
        {
            num += q;
            return num;
        }
        static int Gatnum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instnces name of method
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(Addnum);
            NumberChanger nc2 = new NumberChanger(Multnum);

            //calling
            nc1(12);
            Console.WriteLine("the result of sum : {0}", Gatnum());
            nc2(2);
            Console.WriteLine("The result of multiplication : {0}", Gatnum());

            //nc(4);

            nc = nc1;
            nc += nc2;
            nc(4);
            Console.WriteLine("result of malticast nc {0}", Gatnum());
            Console.ReadKey();


        }
    }
}
