using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_10
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < range; i++)
            {
                string input = Console.ReadLine();
                int[] arr = new int[26];
                char tempChr = ' ';
                bool right = true;

                for (int j = 0; j < input.Length; j++)
                {

                    if (tempChr == input[j])
                        continue;

                    if (arr[input[j] - 97] == 0)
                        arr[input[j] - 97]++;
                    else
                    {
                        right = false;
                        break;
                    }

                    tempChr = input[j];
                }
                if (right)
                    count++;
            }

            Console.WriteLine(count);

        }
    }
}
