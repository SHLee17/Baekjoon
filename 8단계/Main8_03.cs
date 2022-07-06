using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_03
    {

        static void Main1(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int i = 2;
            int b = a;

            while (i <= Math.Sqrt(a))
            {
                if(a % i == 0)
                {
                    Console.WriteLine(i);
                    a /= i;
                }
                else
                i++;
            }

            if(b != 1)
                Console.WriteLine(a);

        }
    }
}
