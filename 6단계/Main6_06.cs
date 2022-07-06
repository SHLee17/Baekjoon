using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_06
    {
        static void Main1(string[] args)
        {

            string str = Console.ReadLine();
            int count = 0;
            bool isWord = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && !isWord)
                {
                    count++;
                    isWord = true;
                }
                else if (str[i] == ' ' && isWord)
                    isWord = false;
            }
            Console.WriteLine(count);
        }
    }
}
