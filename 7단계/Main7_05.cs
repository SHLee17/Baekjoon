using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_05
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < range; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int floor = 0;
                int num = 0;
                int h = int.Parse(inputs[0]);
                int w = int.Parse(inputs[1]);
                int n = int.Parse(inputs[2]);

                floor = n % h * 100;
                num = n / h + 1;

                if (n % h == 0)
                {
                    floor = h * 100;
                    num = n / h;
                }
                else
                {
                    floor = (n % h) * 100;
                    num = n / h + 1;
                }

                sb.AppendLine((floor + num).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
