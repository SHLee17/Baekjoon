using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_3
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int i, j;
            int n = int.Parse(sr.ReadLine());
            int[] cArr = new int[10001];
            for (i = 0; i < n; i++)
                cArr[int.Parse(sr.ReadLine())]++;

            for (i = 0; i <= 10000; i++)
            {
                if (cArr[i] != 0)
                {
                    for (j = 0; j < cArr[i]; j++)
                        sw.Write(i + "\n");
                }
            }

        }
    }
}
