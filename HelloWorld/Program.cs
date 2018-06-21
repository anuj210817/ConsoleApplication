using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
            Console.ReadKey();
        }
        public static string CreateMessage()
        {
            return "Hello world";
        }
    }
}
