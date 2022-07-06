using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._6단계
{
    internal class Main6_05
    {
        static void Main1(string[] args)
        {

            int[] count = new int[26];

            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                //ASCll a = 97 A = 65
                count[str[i] >= 'a' ? str[i] - 'a' : str[i] - 'A']++;
            }

            int bigest = count[0];
            int answer = 0;
            bool isOnly = true;

            for (int i = 1; i < 26; i++)
            {
                if(bigest < count[i])
                {
                    bigest = count[i];
                    answer = i;
                }
                else if (bigest == count[i])
                {
                    isOnly = false;
                }
            }

            Console.WriteLine(isOnly ? (char)(answer + 'A') :"?");
            #region old
                //string strInput = Console.ReadLine().ToUpper();

                //Dictionary<int, int> countDic = new Dictionary<int, int>();
                //string str = "";

                //foreach (char item in strInput)
                //{
                //    if (!countDic.ContainsKey(item))
                //        countDic.Add(item, 1);
                //    else
                //        countDic[item]++;
                //}
                //int count = 0;
                //foreach (KeyValuePair<int, int> item in countDic)
                //{
                //    if (countDic.Values.Max() == item.Value)
                //    {
                //        str += (char)item.Key;
                //        count++;
                //    }

                //    if (count > 1)
                //    {
                //        str = "?";
                //        break;
                //    }
                //}
                //Console.WriteLine(str);

                #endregion

        }
    }
}
