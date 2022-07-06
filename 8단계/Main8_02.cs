using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_02
    {

        static void Main1(string[] args)
        {
            int count = 0;
            int min = 0;
            int start = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());
            //List<int> nums = new List<int>();

            for (int i = start; i <= range; i++)
            {
                if (Answer(i))
                {
                    if (count == 0)
                        min = i;
                    count += i;
                }
            }
            if (count == 0) count = -1;
            Console.WriteLine(count);
            if (min == 0) return;
            Console.WriteLine(min);
        }
        public static bool Answer(int value)
        {
            if (value == 1) return false;
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
