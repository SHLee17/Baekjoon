using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_03
    {
        class Bulk
        {
            public int w;
            public int h;
            public Bulk(int w, int h)
            {
                this.w = w;
                this.h = h;
            }
        }
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<Bulk> list = new List<Bulk>();
            //{
            //    new Bulk(55, 185),
            //    new Bulk(58, 183),
            //    new Bulk(88, 186),
            //    new Bulk(60, 175),
            //    new Bulk(46, 155)
            //};


            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split();

                list.Add(new Bulk(int.Parse(input[0]), int.Parse(input[1])));
            }

            int count = 1;

            for (int i = 0; i < a; i++)
            {
                count = 1;
                for (int j = 0; j < a; j++)
                {
                    if (list[i] != list[j])
                    {
                        if (list[i].w < list[j].w && list[i].h < list[j].h)
                            count++;

                    }

                }
                Console.Write($"{count} ");
            }

        }
    }
}
