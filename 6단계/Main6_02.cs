using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_02
    {
        static void Main1(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            string strNum = Console.ReadLine();
            int sum = 0;

            foreach (char item in strNum)
                sum += int.Parse(item.ToString());

            Console.WriteLine(sum);
        }
    }
}
