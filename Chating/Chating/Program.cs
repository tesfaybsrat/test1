using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chating
{
    class Twochat
    {
        string name;
        string portnumber;
        string codetoexist;
        string message;
    public void UserConnection()
        {
            Console.WriteLine("Enter your name :");
       name=Console.ReadLine();
            Console.WriteLine("Enter your port number :");
 portnumber=Console.ReadLine();
            Console.WriteLine("Enter your code to exist :");
codetoexist = Console.ReadLine();
        }
        public void chat()
        {
            Console.WriteLine("Message :");
            for (int i = 0; i < 10; i++)
            {
                message = Console.ReadLine();
                if (message == codetoexist)
                {
                    Console.WriteLine("break");
                }
                else
                {
                    Console.WriteLine("Message :", message);
                }
            }
        }
    }
    class displaymessages
    {
        static void Main(string[] args)
        {
            Twochat chat = new Twochat();
                chat.UserConnection();
                chat.chat();
                //Console.ReadKey();
        }
    }
}
