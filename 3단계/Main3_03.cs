using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main3_03
    {
        static void Main1(string[] args)
        {

            while (true)
            {
                string str = Console.ReadLine();

                if (str == null) break;

                string[] arr = str.Split();

                int temp1 = int.Parse(arr[0]);
                int temp2 = int.Parse(arr[1]);

                Console.WriteLine(temp1 + temp2);
            }

        }
    }
}
