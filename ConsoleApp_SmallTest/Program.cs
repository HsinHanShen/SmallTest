﻿using System;
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
            string inStr = "";
            bool isExit;
            Exercise myEx = new Exercise();

            do
            {
                Console.WriteLine("=== Small Test App ===");
                Console.WriteLine("\t 1) print star.");
                Console.WriteLine("\t 2) xxx test.");
                Console.Write("\t Please select number : ");

                inStr = Console.ReadLine();
                switch (inStr)
                {
                    case "2":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);

                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "3":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);

                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "4":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);

                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "1":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex01_PrintStar();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                }


                Console.Write("Press 'E' to exit: ");


                inStr = Console.ReadLine();
                isExit = inStr.Equals("E");
                if (isExit == true)
                    Console.WriteLine("\n ...Goodbye");
                else
                    Console.WriteLine("\nRepert App ...");

            } while (isExit == false);           









        }
    }
}
