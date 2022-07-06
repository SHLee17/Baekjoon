using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_07
    {
        static void Main1(string[] args)
        {

            string[] str = Console.ReadLine().Split();
            string[] nums = new string[2];

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = str[i].Length - 1; j >= 0 ; j--)
                {
                    nums[i] += str[i][j];
                }
            }
            Console.WriteLine(int.Parse(nums[0]) > int.Parse(nums[1]) ? nums[0] : nums[1]);
        }
    }
}
