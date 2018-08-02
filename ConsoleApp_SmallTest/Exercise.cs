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
            try
            {
                int A = Int32.MaxValue;
                int B = 2;
                int ans = 0;

                ans = (A + B);

                Console.WriteLine("A = {0}", A);
                Console.WriteLine("B = {0}", B);
                Console.WriteLine("A + B = {0}", ans);
            }
            catch (Exception e)
            {
                //Console.WriteLine("發生例外狀況 : {0}", e.ToString());
                Console.WriteLine("發生例外狀況 : {0}", e.Message);
            }



            return 0;
        }
        #endregion
    }
}
