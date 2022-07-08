using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_4
    {
        static void Main1(string[] args)
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int m = 4000;
            int n = int.Parse(sr.ReadLine());
            int[] nArr = new int[m * 2 + 1];

            int max = -m;
            int min = m;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(sr.ReadLine());
                nArr[m + temp]++;

                if (max < temp)
                    max = temp;
                if (min > temp)
                    min = temp;

                sum += temp;
            }

            bool isModeValue = true;
            int modeIndex = 0;
            int modeValue = 0;
            int halfIndex = n / 2 + 1;
            int midCount = 0;
            int midNum = 0;
            bool isFindMidNum = false;

            for (int i = 0; i <= m * 2; i++)
            {
                if (!isFindMidNum)
                {
                    midCount += nArr[i];
                    if (midCount >= halfIndex)
                    {
                        midNum = i;
                        isFindMidNum = true;
                    }
                }

                if (modeIndex < nArr[i])
                {
                    modeIndex = nArr[i];
                    isModeValue = true;
                    modeValue = i;

                }
                else if (isModeValue)
                {
                    if (nArr[i] == modeIndex)
                    {
                        isModeValue = false;
                        modeValue = i;
                    }
                }
  
            }

            sw.WriteLine((int)Math.Round(sum / n));
            sw.WriteLine(midNum - m);
            sw.WriteLine(modeValue - m);
            sw.WriteLine(max - min);
        }
    }
}
