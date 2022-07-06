using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_01
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Factoral(a));
        }

        static int Factoral(int n)
        {
            if (n == 1)
                return n;
            else if (n == 0)
                return 1;

                return n * Factoral(n - 1);
            
        }
    }
}
