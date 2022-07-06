using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_01
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] num = new int[range];

            string[] value = Console.ReadLine().Split();

            for (int i = 0; i < range; i++)
                num[i] = int.Parse(value[i]);

            Console.WriteLine("{0} {1}", num.Min(), num.Max());
        }
    }
}
