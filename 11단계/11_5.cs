using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_5
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int[] nArr = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
                nArr[i] = int.Parse(n[i].ToString());

            QuickSort(nArr, 0, nArr.Length - 1);

            foreach (int item in nArr)
                Console.Write(item);
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right) 
            {
                int pivot = left;
                for (int i = pivot; i < right; i++)
                {
                    if (arr[i] <= arr[right])
                    {
                        Swap(ref arr[pivot], ref arr[i]);
                        pivot++;
                    }
                }
                Swap(ref arr[pivot], ref arr[right]);

            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
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
