using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_07
    {
        static void Main1(string[] args)
        {

            int kg = int.Parse(Console.ReadLine());

            int num = 0;


            while (kg >= 0)
            {
                if (kg % 5 == 0)
                {
                    num += kg / 5;
                    Console.WriteLine(num);
                    return;
                }
                //if (kg == 4) 
                kg += -3;
                num++;
            }
            Console.WriteLine(-1);  
        }
    }
}
