using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_03
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int x = 1, y = 1;
            int x1 = 1, y1 = -1;
            int temp = 0;
            while (true)
            {
                if (1 == input) break;

                if (x == 1)
                {
                    y++;
                    temp = y;
                    input--;
                }
                else if (y == 1)
                {
                    x++;
                    temp = x;
                    input--;
                }
                for (int i = 1; i < temp; i++)
                    {
                    if (1 == input) break;
                        x += x1;
                        y += y1;
                        input--;
                    }
                x1 *= -1;
                y1 *= -1;
            }

            Console.WriteLine("{0}/{1}", x, y);
        }

    }
}
