using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main3_01
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] str = Console.ReadLine().Split();

            int range = int.Parse(str[0]);

            int value = int.Parse(str[1]);

            string[] str1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < range; i++)
            {
                int temp = int.Parse(str1[i]);

                if (temp < value)
                    sb.Append(temp + " ");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
