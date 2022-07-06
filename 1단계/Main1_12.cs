using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._1단계
{
    internal class Main1_12
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int a = (int.Parse(num[0])),
                b = (int.Parse(num[1])),
                c = (int.Parse(num[2]));

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b + c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine(((a % c) * (b + c)) % c);
        }

    }
}
