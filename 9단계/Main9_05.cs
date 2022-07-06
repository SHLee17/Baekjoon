using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_05
    {
        static StringBuilder sb = new StringBuilder();
        static int count = 0;

        static void Main1(string[] args)
        {
            string temp = Console.ReadLine();

            int height = int.Parse(temp);


            Hanoi(height, 1, 2, 3);

            sb.Insert(0, $"{count}\n");

            Console.WriteLine(sb);
        }

        public static void Hanoi(int n, int A, int B, int C)
        {
            if (n == 1)
            {
                sb.Append($"{A} {C}\n");
                count++;
            }
            else
            {
                Hanoi(n - 1, A, C, B);
                sb.Append($"{A} {C}\n");
                count++;
                Hanoi(n - 1, B, A, C);
            }

        }

    }
}

