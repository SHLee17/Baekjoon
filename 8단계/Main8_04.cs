using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_04
    {

        static void Main1(string[] args)
        {

            string[] inputs = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            int range = int.Parse(inputs[1]);

            bool[] temp = new bool[range + 1];

            for (int i = 2; i <= Math.Sqrt(range); i++)
            {
                if (temp[i]) continue;
                for (int j = i * 2; j <= range; j += i)
                    temp[j] = true;
            }

            for (int i = int.Parse(inputs[0]); i <= range; i++)
            {
                if (!temp[i] && i > 1)
                    sb.Append(i + "\n");
            }

            Console.WriteLine(sb);
        }

    }
}
