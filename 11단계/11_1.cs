using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_1
    {
        static void Main1(string[] args)
        {
            int i, j, key;

            int n = int.Parse(Console.ReadLine());
            int[] nArr = new int[n];

            for (i = 0; i < n; i++)
                nArr[i] = int.Parse(Console.ReadLine());

            #region 버블정렬

            //for (i = n - 1; i > 0; i--)
            //{
            //    for (j = 0; j < i; j++)
            //    {
            //        if (nArr[j] > nArr[i])
            //        {
            //            int temp = nArr[i];
            //            nArr[i] = nArr[j];
            //            nArr[j] = temp;
            //        }
            //    }
            //}

            //foreach (int item in nArr)
            //    Console.Write($"{item}\n");
            #endregion


            #region 선택정렬
            for (i = 1; i < n; i++)
            {
                key = nArr[i];


                for (j = i - 1; j >= 0 && nArr[j] > key; j--)
                    nArr[j + 1] = nArr[j];

                nArr[j + 1] = key;
            }

            foreach (int item in nArr)
                Console.Write($"{item} ");
            #endregion
        }
    }
}
