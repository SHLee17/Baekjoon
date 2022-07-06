using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_08
    {
        static void Main1(string[] args)
        {

            string[] AB = Console.ReadLine().Split();
            string A, B;
            int n, m;

            if (AB[0].Length >= AB[1].Length)
            {
                A = AB[0];
                B = AB[1];
                n = AB[0].Length;
                m = AB[1].Length;
            }
            else
            {
                A = AB[1];
                B = AB[0];
                n = AB[1].Length;
                m = AB[0].Length;
            }

            char[] sum = new char[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (m - i - 1 >= 0) sum[n - i] += (char)(A[n - i - 1] + B[m - i - 1] - '0');
                else sum[n - i] += (char)A[n - i - 1];
                if (sum[n - i] > '9' && i != n - 1)
                {
                    sum[n - i - 1]++;
                    sum[n - i] = (char)(sum[n - i] - 10);
                }
                if (sum[n - i] > '9' && i == n - 1)
                {
                    sum[n - i - 1] = '1';
                    sum[n - i] = (char)(sum[n - i] - 10);
                }
            }
            string str = new string(sum);
            if (sum[0] != '1') str = str.Substring(1);
            Console.WriteLine(str);


        }
    }
}



//string[] inputs = Console.ReadLine().Split();
//int i = 0;

//List<List<int>> numList = new List<List<int>>();

//List<int> add = new List<int>();

//foreach (var item in inputs)
//{
//    List<int> temp = new List<int>();
//    for (i = item.Length - 1; i >= 0; i--)
//        temp.Add(int.Parse(item[i].ToString()));

//    numList.Add(temp);
//}


//int length = numList[0].Count > numList[1].Count ? numList[0].Count : numList[1].Count;
//int p = 0;
//i = 0;

//while (true)
//{
//    if (numList[0].Count <= i || numList[1].Count <= i)
//    {
//        int j = numList[0].Count <= i ? 1 : 0;
//        while (numList[j].Count > i)
//        {

//            p = numList[j][i] + p;
//            if (p >= 10)
//            {
//                add.Add(p % 10);
//                p = 1;
//            }
//            else
//            {
//                add.Add(p);
//                p = 0;
//            }

//            i++;
//        }
//        if (p == 1)
//            add.Add(p);
//        break;
//    }

//    p = numList[0][i] + numList[1][i] + p;
//    if (p >= 10)
//    {
//        add.Add(p % 10);
//        p = 1;
//    }
//    else
//    {
//        add.Add(p);
//        p = 0;
//    }
//    i++;
//}

//add.Reverse();
//add.ForEach(x => Console.Write(x));

//BigInteger[] nums = new BigInteger[2]
//{
//    BigInteger.Parse(inputs[0]),
//    BigInteger.Parse(inputs[1]),
//};

//Console.WriteLine(nums[0] + nums[1]);


