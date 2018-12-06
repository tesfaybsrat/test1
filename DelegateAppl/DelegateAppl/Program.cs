using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAppl
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        //delegate declaration
        public delegate void printString(string s);

        //this  method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("the string is : {0}", str);
        }

        // this method prints to file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("C:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        //this method take the delegate as parameter and uses it to call the method as required
        public static void sendString(printString ps)
        {
            ps("hell wold");
        }
        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}
