using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_05
    {

        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool[] primeNumbers = new bool[246913];
            int halfRange = (int)Math.Sqrt(246913);
            int count;
            int a = 1,i, j;
            
            for (i = 2; i <= halfRange; i++)
            {
                if (primeNumbers[i]) continue;
                for (j = i + i; j < 246913; j += i)
                    primeNumbers[j] = true;
            }

            while (true)
            {
                a = int.Parse(Console.ReadLine());

                if (a == 0) break;

                count = 0;

                

                for (i = a + 1 ; i <= a*2; i++)
                {
                    if (i <= 1) continue;
                    if (!primeNumbers[i])
                        count++;
                }

                sb.Append(count + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
