using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_03
    {
        static void Main1(string[] args)
        {
            int[] nums = new int[3];
            int[] counters = new int[10];
            int multiple = 0;
            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(Console.ReadLine());

            multiple = nums[0] * nums[1] * nums[2];
            string temp = multiple.ToString();


            foreach (char item in temp)
            {
                int index = int.Parse(item.ToString());
                counters[index]++;
            }

            foreach (int item in counters)
                Console.WriteLine(item);
        }
    }
}
