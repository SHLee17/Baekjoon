using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_04
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string answer = "";


            for (int i = 0; i < input; i++)
            {
                string[] str = Console.ReadLine().Split();
                for (int k = 0; k < str[1].Length; k++)
                {
                    for (int j = 0; j < int.Parse(str[0]); j++)
                        answer += str[1][k];
                }

                answer += "\n";
            }
         
            Console.WriteLine(answer);
        }
    }
}
