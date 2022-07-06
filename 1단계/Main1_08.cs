using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._1단계
{
    internal class Main1_08
    {

        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            Console.WriteLine(double.Parse(num[0]) / double.Parse(num[1]));
        }
    }
}
