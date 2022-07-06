using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_02
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

                Console.WriteLine(Answer(a));

        }

        static int Answer(int n)
        {
            if (n <= 1)
                return n;

            return Answer(n - 1) + Answer(n - 2);
            
        }
    }
}
