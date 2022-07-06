using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main3_04
    {
        static void Main1(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int num1 = num;

            while (true)
            {
                int temp1 = num1 / 10;

                int temp2 = num1 % 10;

                int temp3 = temp1 + temp2;

                num1 = (temp2 * 10) + (temp3 % 10);

                count++;

                if (num1 == num)
                    break;
            }

            Console.WriteLine(count);

        }
    }
}
