using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_05
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 666;
            int count = 0;

            while (true)
            {
                string str = answer.ToString();
                for (int i = 0; i < str.Length - 2; i++)
                {
                    if (str[i] == '6' && str[i + 1] == '6' && str[i + 2] == '6')
                    {
                        count++;

                        break;
                    }
                }

                if (count == n)
                {
                    Console.Write(answer);
                    return;
                }


                answer++;

            }
        }
    }
}
