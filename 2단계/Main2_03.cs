using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main2_03
    {
        static void Main1(string[] args)
        {
            //4 100 400

            string temp = Console.ReadLine();

            int num = int.Parse(temp);

            if(num % 4 == 0)
            {
                if(num % 100 == 0)
                {
                    if(num % 400 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                        Console.WriteLine("0");
                }
                else
                Console.WriteLine("1");

            }
            else
                Console.WriteLine("0");

        }
    }
}
