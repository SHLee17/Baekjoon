using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main3_02
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] str = Console.ReadLine().Split();

                int temp1 = int.Parse(str[0]);
                int temp2 = int.Parse(str[1]);
                
                if (temp1 == 0 && temp2 == 0)
                    break;

                sb.Append(temp1 + temp2 + "\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
