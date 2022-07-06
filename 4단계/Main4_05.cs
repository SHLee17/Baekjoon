using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_05
    {
        static void Main1(string[] args)
        {

            int range = int.Parse(Console.ReadLine());
            string[] strScores = Console.ReadLine().Split();
            double[] scores = new double[range];
            double avrg = 0;

            for (int i = 0; i < scores.Length; i++)
                scores[i] = double.Parse(strScores[i]);

            foreach (int item in scores)
                avrg += (item / scores.Max()) * 100;

            Console.WriteLine(avrg/range);
        }

    }
}
