using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_04
    {
        static void Main1(string[] args)
        {

            string[] str = Console.ReadLine().Split();

            int a = int.Parse(str[0]), b = int.Parse(str[1]);

            bool[,] chessBoard = new bool[a,b];

            #region Test
            //string[] tempLine = new string[]
            //{
            //    "BBWBWBWB",
            //    "BWBWBWBW",
            //    "WBWBWBWB",
            //    "BWBWBWBW",
            //    "WBWBWBWB",
            //    "BWBWBWBW",
            //    "WBWBWBWB", 
            //    "BWBWBWBW",
            //};

            //for (int j = 0; j < a; j++)
            //{

            //    for (int i = 0; i < tempLine[j].Length; i++)
            //    {
            //        if ('w' == tempLine[j][i] || 'W' == tempLine[j][i])
            //            chessBoard[j, i] = true;
            //        if ('b' == tempLine[j][i] || 'B' == tempLine[j][i])
            //            chessBoard[j, i] = false;
            //    }
            //}
            #endregion

            for (int j = 0; j < a; j++)
            {
                string tempLine = "";

                tempLine = Console.ReadLine();

                for (int i = 0; i < tempLine.Length; i++)
                {
                    if ('w' == tempLine[i] || 'W' == tempLine[i])
                        chessBoard[j, i] = true;
                    if ('b' == tempLine[i] || 'B' == tempLine[i])
                        chessBoard[j, i] = false;
                }
            }


            int count = 9999;

            for (int y = 0; y <= a - 8; y++)
            {
                for (int x = 0; x <= b - 8; x++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        bool temp = k % 2 == 0 ? chessBoard[y, x] : !chessBoard[y, x];
                        int tempCount = 0;

                        for (int i = 0 + y; i < 8 + y; i++)
                        {
                            for (int j = 0 + x; j < 8 + x; j++)
                            {
                                if (temp != chessBoard[i, j])
                                    tempCount++;
                                temp = !temp;
                            }
                            temp = !temp;
                        }
                        if (count > tempCount) count = tempCount;
                    }
                }
            }
            

            Console.WriteLine(count);

        }
    }
}
