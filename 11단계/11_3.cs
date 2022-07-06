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
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int i, n, m;

            n = int.Parse(sr.ReadLine());

            int[] a = new int[n];
            for (i = 0; i < n; i++)
                a[i] = int.Parse(sr.ReadLine());

            m = a.Max();
            int[] c = new int[m + 1];
            int[] o = new int[n];

            for (i = 0; i < n; i++)
                c[a[i]]++;
            for (i = 1; i <= m; i++)
                c[i] += c[i - 1];
            for (i = 0; i < n; i++)
            {
                int target = a[i];
                o[c[target] - 1] = target;
                c[target]--;
            }


            foreach (int item in o)
                sb.Append(item).Append(" ");

            sw.Write(sb);

            sw.Close();
            sr.Close();
        }        
    }
}
