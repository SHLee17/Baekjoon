using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_09
    {
        static void Main1(string[] args)
        {
            string[] alphabetList =
            {
                "c=", "c-", "dz=","d-",
                "lj", "nj", "s=", "z="
            };

            string input = Console.ReadLine();
            //input.Replace("c=", "0"); 이걸 쓰면 됨
            int wordCount = 0;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(wordCount >0)
                {
                    wordCount--;
                    continue;
                }
                for (int j = 0; j < alphabetList.Length; j++)
                {
                    if (input[i] == alphabetList[j][0])
                    {
                        if (i + 1 < input.Length)
                        {
                            if (input[i + 1] == alphabetList[j][1])
                            {
                                if(i+2 < input.Length && alphabetList[j].Length > 2)
                                {
                                    if( input[i+2] == alphabetList[j][2])
                                    {
                                        wordCount = 2;
                                        count++;
                                        continue;

                                    }

                                }
                                if (j != 2)
                                {
                                    wordCount = 1;
                                    count++;
                                    continue;
                                }
                            }
                        }
                    }
                }
                if (wordCount == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
