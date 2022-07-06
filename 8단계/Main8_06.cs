using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_06
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool[] primeNumbers = new bool[10001];
            int halfRange = (int)Math.Sqrt(10000);

            int i, j, k;

            for (i = 2; i <= halfRange; i++)
            {
                if (primeNumbers[i]) continue;
                for (j = i + i; j < primeNumbers.Length; j += i)
                    primeNumbers[j] = true;
            }

            int a = int.Parse(Console.ReadLine());
            int b;

            for (i = 0; i < a; i++)
            {
                b = int.Parse(Console.ReadLine());
                j = b / 2;
                k = b / 2;

                if (b % 2 == 0)
                {
                    while (true)
                    {
                        if (!primeNumbers[j] && !primeNumbers[k])
                        {
                            if (j + k == b)
                            {
                                sb.AppendFormat($"{j} {k}\n");
                                break;
                            }
                        }
                        j--;
                        k++;
                    }
                }

            }
            Console.WriteLine(sb);

        }
    }
}
