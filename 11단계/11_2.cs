using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_2
    {
        static void Main1(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int i, n = int.Parse(sr.ReadLine());
            int[] nArr = new int[n];

            for (i = 0; i < n; i++)
                nArr[i] = int.Parse(sr.ReadLine());

            for (i = n - 1 / 2; i >= 0; i--)
                SortHeap(nArr, i, n);
            for (i = n - 1; i > 0; i--)
            {
                Swap(ref nArr[i], ref nArr[0]);
                SortHeap(nArr, 0, i);
            }



            foreach (int item in nArr)
                sb.Append(item).Append('\n');

            sw.Write(sb);

            sr.Close();
            sw.Close();
        }

        static void SortHeap(int[] arr, int root, int length)
        {
            while (root < length)
            {
                int child = root * 2 + 1;

                if (child + 1 < length && arr[child] < arr[child + 1])
                    ++child;
                if (child < length && arr[root] < arr[child])
                {
                    Swap(ref arr[root], ref arr[child]);
                    root = child; ;
                }
                else break;
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
