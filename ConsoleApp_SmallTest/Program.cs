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
            string inStr = "";
            bool isExit;
            Exercise myEx = new Exercise();

            do
            {
                Console.WriteLine("=== Small Test App ===");
                Console.WriteLine("\t 1) print star.");
                Console.WriteLine("\t 2) xxx test.");
                Console.WriteLine("\t 3) Add Two Numbers [Linked List].");
                Console.WriteLine("\t 4) Length Of Longest Substring.");
                Console.WriteLine("\t 5) Reverse Numbers.");
                Console.WriteLine("\t 6) Overflow Detection.");
                Console.WriteLine("\t 7) Logic ADD.");
                Console.WriteLine("\t 8) 九九乘法表");
                Console.Write("\t Please select number : ");

                inStr = Console.ReadLine();
                switch (inStr)
                {
                    case "1":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex01_PrintStar();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "2":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex02_PrintSwap();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "3":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex03_AddTwoNumbers();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "4":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex04_LengthOfLongestSubstring();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "5":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex05_ReverseNumbers();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "6":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex06_OverflowDetection();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "7":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex07_LogicADD();
                        Console.WriteLine("====== Exercise end ======");
                        break;
                    case "8":
                        Console.WriteLine("<<< Exercise_{0} start >>>", inStr);
                        myEx.Ex08_table_9x9();
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
