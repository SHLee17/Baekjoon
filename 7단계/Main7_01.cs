using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_01
    {
        static void Main1(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]), 
                b = int.Parse(str[1]), 
                c = int.Parse(str[2]);
            if (c <= b)
                Console.WriteLine(-1);
            else
                Console.WriteLine((a / (c-b)) + 1);



            //while (true)
            //{
            //    count++;
            //    if (c <= b) 
            //    {
            //        count = -1;
            //            break;
            //    }

            //    if (a + (b * count) < c * count)
            //        break;
            //}
        }
    }
}
