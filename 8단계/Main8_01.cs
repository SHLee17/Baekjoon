using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_01
    {

        static void Main1(string[] args)
        {
            int count = 0;
            int range = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split();

            for (int i = 0; i < range; i++)
            {
                if( Answer(int.Parse( inputs[i])))
                    count++;
            }

            Console.WriteLine(count);



        }
        public static bool Answer(int value)
        {
            if (value == 1) return false;
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
