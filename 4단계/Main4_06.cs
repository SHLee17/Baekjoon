using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_06
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            string[] strOX = new string[range];
            int[] scores = new int[range];
            int score = 0;
            for (int i = 0; i < range; i++)
                strOX[i] = Console.ReadLine();

            for (int i = 0; i < range; i++)
            {
                foreach (char item in strOX[i])
                {
                    if (item == 'o' || item == 'O')
                    {
                        score++;
                        scores[i] += score;
                    }
                    else
                        score = 0;
                }
                Console.WriteLine(scores[i]);
                score = 0;
            }
        }

    }
}
