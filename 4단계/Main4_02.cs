using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_02
    {
        static void Main1(string[] args)
        {
            int[] nums = new int[9];
            int max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

                if (max < nums[i])
                {
                    max = nums[i];
                    index = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index);


        }
    }
}
