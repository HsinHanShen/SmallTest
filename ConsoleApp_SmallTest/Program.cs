using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SmallTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = (char)0;
            

            int input = 0;
            Console.WriteLine("=== Small Test App ===");
            Console.WriteLine("\t 1) print test.");
            Console.WriteLine("\t 2) xxx test.");
            Console.Write("\t Please select number : ");
            key = Convert.ToChar( Console.Read() );

            string str = input.ToString();
            char c = Convert.ToChar(input);
            Console.WriteLine("\t user input = {0}", c);

            Console.WriteLine("\n\n");
            Console.WriteLine("Press any KEY exit.");
            Console.ReadKey();
        }
    }
}
