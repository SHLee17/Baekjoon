using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baekjoon._9단계
{
    internal class Main9_04
    {
        static int a = 3000;
        static char[,] map = new char[a, a];
        

        static void Main1()
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < a; y++)
            {
                for (int x = 0; x < a; x++)
                {
                    map[y, x] = ' ';
                }
            }
            int n = int.Parse(Console.ReadLine());
            Star(n, 0, 0);

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    sb.Append(map[y, x]);
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

        static void Star(int n, int y, int x)
        {
            if( n == 1)
            {
                map[y, x] = '*';
                return;
            }
            int div = n / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                        continue;


                    Star(div, y + (div * i), x + (div * j));
                }

            }

            return;
        }
    }
}
