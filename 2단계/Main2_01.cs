using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main2_01
    {
        static void Main1(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            if (int.Parse(a[0]) > int.Parse(a[1]))
                Console.WriteLine(">");
            else if(int.Parse(a[0]) < int.Parse(a[1]))
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}
