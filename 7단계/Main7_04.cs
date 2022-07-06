using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_04
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();
    
            int afternoon = int.Parse(input[0]), 
                night = int.Parse(input[1]), 
                goal = int.Parse(input[2]);

            Console.WriteLine(((goal - night - 1) / (afternoon - night)) + 1);


            //day = afternoon - night + afternoon > goal? 2 : (temp / (afternoon - night)) + 1;
            //if (afternoon - night + afternoon > goal)
            //    day = 2;
            //else
            //{
            //    temp = temp / (afternoon - night);
            //    if (temp % 2 == 0)
            //        day = temp + 1;
            //    else
            //        day = temp + 2;
            //}
        }

    }
}
