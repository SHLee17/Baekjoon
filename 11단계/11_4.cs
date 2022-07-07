using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_4
    {
        static void Main(string[] args)
        {

            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            double a = 0;

            int n = int.Parse(sr.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            for (int i = 1; i <= n; i++)
            {
                int temp = int.Parse(sr.ReadLine());
                if (!dict.Keys.Contains(temp))
                    dict.Add(temp, 1);
                else
                    dict[temp]++;

                a += temp;
            }
            a /= n;

            sb.Append((int)Math.Round(a,0)).Append("\n");

            List<int> temps = dict.Keys.OrderBy(x => x).ToList();

            sb.Append(temps[n / 2]).Append("\n");

            temps.Clear();

            foreach (KeyValuePair<int,int> item in dict)
            {
                if (dict.Values.Max() == item.Value)
                    temps.Add(item.Key);
            }

            if (temps.Count > 1)
            {
                List<int> orderList = temps.OrderBy(x => x).ToList();
                sb.Append(orderList[1]).Append("\n");
            }
            else if (temps.Count == 1)
                sb.Append(temps[0]).Append("\n");
            else
                sb.Append(0).Append("\n");

            int max = dict.Keys.Max();
            int min = dict.Keys.Min();

            if (min < 0)
            {
                if (max < 0)
                    sb.Append(Math.Abs(min) - Math.Abs(max)).Append("\n");
                else if (max >= 0)
                    sb.Append(Math.Abs(min) + max).Append("\n");
            }
            else if (min >= 0)
                sb.Append(max - min).Append("\n");

            sw.Write(sb);

        }
    }
}
