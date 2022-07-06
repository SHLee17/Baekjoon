using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_06
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < range; i++)
            {
                int floor = int.Parse(Console.ReadLine()) + 1;
                int num = int.Parse(Console.ReadLine()) + 1;
                int[,] nums = new int[floor, num];
                if (floor > 0)
                {
                    for (int f = 0; f < floor; f++)
                    {
                        for (int n = 1; n < num; n++)
                        {
                            if (f == 0)
                                nums[f, n] = n;
                            else
                            {
                                for (int h = 1; h <= n; h++)
                                    nums[f, n] += nums[f - 1, h];
                            }
                            
                        }
                    }

                    sb.AppendLine(nums[floor - 1, num - 1].ToString());
                }
            }
            Console.WriteLine(sb);

        }
    }
}
