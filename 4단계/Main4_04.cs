using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_04
    {
        static void Main1(string[] args)
        {
            int[] nums = new int[10];
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
                nums[i] = int.Parse(Console.ReadLine());

            foreach (int item in nums)
            {
                int tmep = item % 42;
                if (!list.Contains(tmep))
                    list.Add(tmep);
            }

            Console.WriteLine(list.Count);

        }

    }
}
