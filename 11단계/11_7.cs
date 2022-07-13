using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_7
    {
        struct Coordinate
        {
            public int x, y;

            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

        }
        static void Main1(string[] args)
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            List<Coordinate> coordList = new List<Coordinate>();

            for (int i = 0; i < n; i++)
            {
                string[] strCoord = sr.ReadLine().Split();
                coordList.Add(new Coordinate(int.Parse(strCoord[0]), int.Parse(strCoord[1])));
            }

            coordList.Sort(delegate (Coordinate a, Coordinate b)
            {
                if (a.y == b.y)
                    return a.x.CompareTo(b.x);
                return a.y.CompareTo(b.y);
            });
            foreach (Coordinate item in coordList)
                sb.Append($"{item.x} {item.y}\n");

            sw.Write(sb);
        }
    }
}
