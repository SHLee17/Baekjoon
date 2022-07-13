using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_10
    {
        static void Main1(string[] args)
        {

            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            List<int> indexList = new List<int>();
            Dictionary<int, int> rankIndex = new Dictionary<int, int>();

            string[] nums = sr.ReadLine().Split();

            for (int i = 0; i < nums.Length; i++)
                indexList.Add(int.Parse(nums[i]));

            List<int> temp = indexList.OrderBy(x => x).Distinct().ToList();

            int count = 0;
            foreach (int item in temp)
                    rankIndex.Add(item, count++);

            for (int i = 0; i < indexList.Count; i++)
                sb.Append($"{rankIndex[indexList[i]]} ");

            sw.Write(sb);


            //Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
    }
}
