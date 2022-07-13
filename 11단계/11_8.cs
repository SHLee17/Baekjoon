using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_8
    {
        static void Main1(string[] args)
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());

            List<string> strList = new List<string>();

            for (int i = 0; i < n; i++)
                strList.Add(sr.ReadLine());

            strList = strList.Distinct().ToList();

            strList.Sort(delegate(string a, string b) 
            {
                if (a.Length == b.Length)
                    return a.CompareTo(b);
                return a.Length.CompareTo(b.Length);
            });


            foreach (string item in strList)
                sb.Append(item).Append("\n");
            
            sw.Write(sb);

        }
    }
}
