using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._11단계
{
    internal class _11_9
    {
        struct Member
        {
            public int age;
            public string name;

            public Member(string[] str)
            {
                age = int.Parse(str[0]);
                name = str[1];
            }
        }
        static void Main1(string[] args)
        {

            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(sr.ReadLine());
            List<Member> memberList = new List<Member>();
            
            for (int i = 0; i < n; i++)
                memberList.Add(new Member(sr.ReadLine().Split()));

            IEnumerable<Member> temp = from m in memberList
                                       orderby m.age 
                                       select m;

            foreach (Member item in temp)
                sb.Append($"{item.age} {item.name}\n");

            sw.Write(sb);
        }
    }
}
