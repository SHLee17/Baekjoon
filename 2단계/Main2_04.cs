using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main2_04
    {
        static void Main1(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int x= int.Parse(a);
            int y = int.Parse(b);

            if(Math.Sign(x) == 1)
            {
                if(Math.Sign(y) == 1)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("4");
            }
            else
            {
                if (Math.Sign(y) == 1)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }
    }
}
