using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_03
    {
        static void Main1(string[] args)
        {
            //range 26
            //97 a
            //122 z
            string strNum = Console.ReadLine();
            int count = 0;
            int[] nums = new int[26];
            nums = Enumerable.Repeat(-1, nums.Length).ToArray();

            string answer = "";

            foreach (char item in strNum)
            {
                int index = Convert.ToInt32(item) - 97;
                if (nums[index] == -1)
                    nums[index] = count;
                count++;
            }

            foreach (int item in nums)
                answer += item + " ";

            Console.WriteLine(answer);

        }
    }
}
