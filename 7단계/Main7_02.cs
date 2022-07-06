using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_02
    {
        static void Main1(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temp = 1;
            int count = 1;
            while (true)
            {
                if (temp >= num)
                    break;
                temp += 6 * count;

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
