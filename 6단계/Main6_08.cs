using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_08
    {
        static void Main1(string[] args)
        {
            //1 은 2초 1초씩 증감
            string str = Console.ReadLine();
            int second = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int temp = Convert.ToInt32(str[i]);
                
                if (temp >= 80 && temp <= 83)
                {
                        second += 8;
                    continue;
                }
                else if (temp >= 84 && temp <= 86)
                {
                        second += 9;
                    continue;
                }
                else if(temp >= 87)
                {
                    second += 10;
                    continue;
                }
                second += ((str[i] - 65) / 3) + 3;
            }
            Console.WriteLine(second);
        }
    }
}
