using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main5_01
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool[] selfNums = new bool[10001];
            selfNums = Enumerable.Repeat(true, selfNums.Length).ToArray();

            for (int i = 1; i <= 10000; i++)
            {
                int temp = SelfNumber(i.ToString()); 
                if (temp <= 10000)
                selfNums[temp] = false;
            }

            for (int i = 1; i <= 10000; i++)
            {
                if (selfNums[i])
                    sb.Append(i.ToString() + "\n");
            }

            Console.WriteLine(sb.ToString());
        }

        static int SelfNumber(string num)
        {
            int length = num.Length;
            int number = int.Parse(num);

            for (int i = 0; i < length; i++)
                number += int.Parse(num[i].ToString());

            return number;
        }
    }
}
