using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your username");
            var username = Console.ReadLine();
            var user = new User(username);
            user.Join();
            while (true)
            {
                var msg = Console.ReadLine();
                user.Write(msg);
            }
        }
    }
}
