using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_07
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string[] input = Console.ReadLine().Split();
                int count = int.Parse(input[0]);
                int[] inputNum = new int[count + 1];

                int avrgScore = 0;
                int avrgCount = 0;

                for (int j = 1; j < count + 1; j++)
                {
                    inputNum[j] = int.Parse(input[j]);

                    avrgScore += inputNum[j];
                }

                avrgScore = avrgScore / count;

                for (int j = 1; j < count + 1; j++)
                {
                    if (avrgScore < inputNum[j])
                        avrgCount++;
                }

                float avrg = (float)avrgCount / count * 100;

                Console.WriteLine($"{avrg:F3}%");
            }
        }

    }
}
