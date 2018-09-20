using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SmallTest
{

    public class ListNode
    {
        public int val;
        public ListNode next = null;

        public ListNode(int x) { val = x; }
    }



    class Exercise
    {
        #region ex01 - PrintStar
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
        #endregion

        #region ex02 - PrintSwap
        public int Ex02_PrintSwap()
        {
            char[] number = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] tmp = number;

            for (int i = 0; i < number.Length; i++)
                tmp[i] = number[i];

            string str = new string(number);
            Console.WriteLine("original number array = {0}", str);
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = tmp[number.Length - i - 1];
            }
            str = new string(number);
            Console.WriteLine("Swap number array = {0}", str);

            return 0;
        }
        #endregion

        #region ex03 - Add Two Numbers
        public int Ex03_AddTwoNumbers()
        {
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode l3;

            ListNode curr1 = l1;
            ListNode curr2 = l2;

            /*// Smaple 1
            curr1.val       = 2;
            curr1.next      = new ListNode(4);
            curr1           = curr1.next;
            curr1.next      = new ListNode(3);

            curr2.val       = 5;
            curr2.next      = new ListNode(6);
            curr2           = curr2.next;
            curr2.next      = new ListNode(4);
            */

            // Sample 2
            curr1.val = 9;

            curr2.val = 1;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);
            curr2 = curr2.next;
            curr2.next = new ListNode(9);






            l3 = AddTwoNumbers(l1, l2);

            Console.Write("List1 + List2 value = ");
            while (l3 != null)
            {
                Console.Write("{0}, ", l3.val);

                l3 = l3.next;
            }
            Console.WriteLine("");

            return 0;
        }



        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = new ListNode(0);
            ListNode curr = ans;
            int val1, val2, sum, carry = 0;

            while (true)
            {
                val1 = l1 != null ? l1.val : 0;
                val2 = l2 != null ? l2.val : 0;
                sum = val1 + val2 + carry;
                curr.val = sum % 10;
                carry = sum / 10;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

                if (l1 == null && l2 == null)
                {
                    if (carry == 1)
                        curr.next = new ListNode(carry);
                    break;
                }
                else
                {
                    curr.next = new ListNode(0);
                    curr = curr.next;
                }
            }

            return ans;
        }
        #endregion

        #region ex04 - Length Of Longest Substring
        public int Ex04_LengthOfLongestSubstring()
        {
            string input = "abcabcdefgabc123456789abc";
            int length;

            try
            {
                length = LengthOfLongestSubstring(input);
                Console.WriteLine("Input = {0}", input);
                Console.WriteLine("Length Of Longest Substring = {0}", length);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.ToString());
            }


            return 0;
        }
        public int LengthOfLongestSubstring(string s)
        {
            /*
            int idx = 1;
            int maxLen = idx;
            char[] buf = new char[s.Length + 1];
            char[] array = s.ToCharArray();


            buf[0] = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                char curr = array[i];
                for (int j = 0; j < idx; j++)
                {
                    // 有重複
                    if ( curr == buf[j] )
                    {   
                        buf[0] = curr;
                        idx = 1;
                    }

                    // 沒又重複
                    if (curr != buf[j] && j == idx - 1)
                    {
                        buf[idx] = curr;
                        idx++;
                        maxLen = idx > maxLen ? idx : maxLen;
                        buf[idx + 1] = '\0';
                        break;
                    }
                }
            }

            Debug.WriteLine("max subString length = {1} , buf[] = \"{0}\"", new string(buf), maxLen);

            return maxLen;
            */
            char[] array = s.ToCharArray();
            char[] buf = new char[s.Length + 1];
            int len = 1;
            int maxLen = len;

            buf[0] = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                char curr = array[i];

                for (int j = 0; j < len; j++)
                {
                    if (curr == buf[j])
                    {
                        len = 1;
                        buf[0] = array[0];
                        break;
                    }

                    if (j == len - 1)
                    {
                        buf[len] = curr;
                        len++;
                        maxLen = len > maxLen ? len : maxLen;
                        break;
                    }
                }
            }
            return maxLen;
        }
        #endregion

        #region ex05 - Reverse Numbers
        public int Ex05_ReverseNumbers()
        {
            int input = -321;
            int x = input;
            /*
            int[] buf = new int[20];
            int idx = 0;
            int ans = 0;

            int weight = 1;

            while (x != 0)
            {
                buf[idx] = x % 10;
                x = x / 10;
                idx++;
            }

            for (int i = idx - 1; i >= 0; i--)
            {

                ans += buf[i] * weight;
                weight = weight * 10;
            }
            Console.WriteLine("Input = {0}", input.ToString());
            Console.WriteLine("Reverse = {0}", ans.ToString());
            */






            Console.WriteLine("Input = {0}", input.ToString());
            int sign = input > 0 ? 1 : -1;
            int ans = 0;



            if (sign < 0)
                input = input * sign;

            string str = input.ToString();
            char[] buf = new char[str.Length + 1];
            for (int i = 0; i < str.Length; i++)
            {
                buf[str.Length - 1 - i] = str.ElementAt(i);
            }
            buf[str.Length] = '\0';
            string strAns = new string(buf);
            ans = Convert.ToInt32(strAns);
            if (sign < 0)
                ans = ans * sign;

            Console.WriteLine("Reverse = {0}", ans.ToString());




            return 0;
        }
        #endregion

        #region ex06 - Overflow Detection
        public int Ex06_OverflowDetection()
        {
            Console.WriteLine("< 使用內建函數checked檢查溢位 >");
            // C# 只走常數運算會透過compiler檢查是否溢位，
            // 對於變數運算，預設不會檢查!!!
            // 必須使用"checked()"來進行溢位偵測
            try
            {
                int A = Int32.MaxValue - 2;
                int B = 2;
                int C = 3;
                int ans = 0;

                Console.WriteLine("A = {0}", A);
                Console.WriteLine("B = {0}", B);
                Console.WriteLine("C = {0}", C);
                Console.WriteLine("-----------------------------");

                Console.WriteLine("A + B");
                // ans = A + B;         // 不會發出例外
                ans = checked(A + B);   // 會檢查例外(溢位)
                Console.WriteLine("{0} + {1} = {2}", A, B, ans);

                Console.WriteLine("-----------------------------");
                Console.WriteLine("A + C");
                // ans = A + C;         // 不會發出例外
                ans = checked(A + C);   // 會檢查例外(溢位)
                Console.WriteLine("{0} + {1} = {2}", A, C, ans);
            }
            catch (Exception e)
            {
                Console.WriteLine("發生例外狀況 : {0}", e.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("< 手動檢查 >");
            // 手動檢查
            try
            {
                int maxInt = 0x7FFFFFFF;
                int minInt = maxInt + 1;

                
                int A = 0x7FFFFFF0;
                int B = 0xF;
                int C = 0x10;
                int ans = 0;
                Console.WriteLine("A = {0}", A);
                Console.WriteLine("B = {0}", B);
                Console.WriteLine("C = {0}", C);
                Console.WriteLine("-----------------------------");

                Console.WriteLine("A + B");
                ans = A + B;
                if (A > maxInt - B)
                    Console.WriteLine("{0} + {1} = Overflow !!!", A , B);
                else
                    Console.WriteLine("{0} + {1} = {2}", A, B, ans);

                Console.WriteLine("-----------------------------");
                Console.WriteLine("A + C");
                ans = A + C;
                if (A > maxInt - C)
                    Console.WriteLine("{0} + {1} = Overflow !!!", A, C);
                else
                    Console.WriteLine("{0} + {1} = {2}", A, C, ans);
            }
            catch (Exception e)
            {
                Console.WriteLine("發生例外狀況 : {0}", e.ToString());
            }

            return 0;
        }
        #endregion

        #region ex07 - Logic ADD
        public int Ex07_LogicADD()
        {
            int A;
            int B;
            Console.WriteLine("-----------------------------");
            A = 1; B = 2;
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("{0} + {1} = {2}", A, B, Logic_ADD(A, B));
            Console.WriteLine("-----------------------------");
            A = 15; B = 25;
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("{0} + {1} = {2}", A, B, Logic_ADD(A, B));
            Console.WriteLine("-----------------------------");
            A = 31; B = 10;
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("{0} + {1} = {2}", A, B, Logic_ADD(A, B));
            Console.WriteLine("-----------------------------");
            A = 255; B = 111;
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("{0} + {1} = {2}", A, B, Logic_ADD(A, B));

            return 0;
        }
        int Logic_ADD(int a, int b)
        {
            int sum = 0;
            int carry = 0;
            do
            {
                sum = a ^ b;
                carry = (a & b) << 1;
                a = sum;
                b = carry;
            } while (b != 0);

            return sum;
        }
        #endregion

        #region ex08 - 九九乘法表
        public int Ex08_table_9x9()
        {
            Console.WriteLine("Recursive Method - 9x9 table");
            Recursive_table_9x9(1, 1);
            Console.WriteLine("Loop Method - 9x9 table");
            Loop_table_9x9(9, 9);

            return 0;
        }
        private void Recursive_table_9x9(int x, int y)
        {
            if (x <= 9)
            {
                if(y <= 9)
                {
                    Console.Write("{0}x{1}={2}\t", y, x, y * x);
                    Recursive_table_9x9(x, y + 1);
                }
                else
                {
                    Console.Write("\n");
                    Recursive_table_9x9(x + 1, 1);
                }
            }
        }
        private void Loop_table_9x9(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write("{0}x{1}={2}\t", j, i, j*i);
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region Boble Sort (氣泡排序法)
        public int Ex09_BobleSort()
        {
            int[] number = new int[] { 15, 1, 33, 23, 67, 91, 13, 54, 37, 8 };
            bool bDone = false;
            int end = number.Length - 1;

            Console.Write("Input : ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("{0} , ", number[i]);
            }
            Console.WriteLine("");

            try
            {
                // 自己寫的版本
                int SwapCn = 0;
                while (bDone == false)
                {
                    bDone = true;
                    for (int i = 0; i < end; i++)
                    {
                        if (number[i] > number[i + 1])
                        {
                            // swap
                            BobleSwap(ref number, i, i + 1);
                            SwapCn++;
                            bDone = false;
                        }
                    }
                    end -= 1;
                }
                
                /*// 網路上的版本
                int SwapCn = 0;
                for (int i = number.Length - 1; i > 1; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (number[j] > number[j+1])
                        {
                            BobleSwap(ref number, j, j + 1);
                            SwapCn++;
                        }
                    }
                }*/



                Console.Write("Output : ");
                for (int i = 0; i < number.Length; i++)
                {
                    Console.Write("{0} , ", number[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("Total Swap Count = {0}", SwapCn);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ex09 : {0}", e.Message);
            }

            return 0;
        }
        private void BobleSwap(ref int [] array, int idx1, int idx2)
        {
            int tmp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = tmp;
        }
        #endregion
    }
}
