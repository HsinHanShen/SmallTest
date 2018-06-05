using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SmallTest
{
    class Exercise
    {
        public int Ex01_PrintStar()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                    Console.Write("*");
                Console.Write("\n");
            }
            

            return 0;
        }



    }
}
