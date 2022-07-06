using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main5_02
    {
        static void Main1(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            if (num > 0 && num < 100)
                count += num;
            else if(num > 0 && num <= 1000)
                count += 99;
            for (int i = 100; i <= num; i++)
            {
                if (ArithmeticSequence(i.ToString()))
                    count++;
            }
            Console.WriteLine(count) ;
        }

        static bool ArithmeticSequence(string num)
        {
            int[] tempNums = new int[num.Length];
            for (int i = 0; i < tempNums.Length; i++)
                tempNums[i] = int.Parse(num[i].ToString());
            if (num.Length == 3)
            {
                if (tempNums[0] - tempNums[1] == tempNums[1] - tempNums[2])
                    return true;
            }

            return false;
        }
    }
}
