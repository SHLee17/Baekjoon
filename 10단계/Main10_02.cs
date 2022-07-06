using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_02
    {
        static void Main1(string[] args)
        {

            string a = Console.ReadLine();
            int n = int.Parse(a);
            int temp = 0;
            int range = (a.Length - 1) * 9 + (int.Parse(a[0].ToString()) - 1);

            for (int i = n-range; i < n; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    temp += int.Parse(i.ToString()[j].ToString());
                }
                temp += i;
                if (temp == n) 
                {
                    temp = i;
                    break;
                }
                else temp = 0;
            }

            Console.WriteLine(temp);
        }

    }
}
