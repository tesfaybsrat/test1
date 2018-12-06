using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUdp
{
    delegate string Mydelegate(string message, int port, int ip);
    class Program
    {
        event Mydelegate Myevent;
        //string message;
        //int port;
        //string ip;

        public Program()
        {
            this.Myevent += new Mydelegate(this.Send);
        }
        public string Send(string message, int port, int ip)
        {
            //message = "hello";
            //port = 7777;
            //ip ="127.0.0.1";
            return message + " " + port + " " + ip;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();
            string result = obj1.Myevent("hello", 7777, 127);
            string result1 = obj2.Myevent("hi", 7777, 127);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
