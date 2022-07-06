using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_01
    {
        static void Main1(string[] args)
        {
            //List<int> list = new List<int>();
            int temp;
            int answer = 0;

            string[] inputs = Console.ReadLine().Split();

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] nums = new int[n];

            string[] inputNums = Console.ReadLine().Split();

            for (int i = 0; i < inputNums.Length; i++)
            {
                nums[i] = int.Parse(inputNums[i]);
            }

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i+1; j < n - 1; j++)
                {
                    for (int h = j+1; h < n; h++)
                    {
                        temp = nums[i] + nums[j] + nums[h];

                        if (temp <= m)
                        {
                            if (temp == m)
                            {
                                Console.WriteLine(temp);
                                return;
                            }
                            if (answer < temp)
                                answer = temp;
                        }
                    }
                }
            }

            Console.WriteLine(answer);
        }

    }
}
