using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._1단계
{
    internal class Main1_13
    {
        static void Main1(string[] args)
        {

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            //int num1 = int.Parse(a);
            //int n1 = int.Parse(b[0].ToString());

            Console.WriteLine(int.Parse(a) * (int.Parse(b) % 10));
            Console.WriteLine(int.Parse(a) * ((int.Parse(b) % 100)/10));
            Console.WriteLine(int.Parse(a) * ((int.Parse(b) % 1000)/100));
            Console.WriteLine(int.Parse(a) * int.Parse(b));
        }
    }
}
