using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_03
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.Write("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.\n");
            Answer(input);
        }
        static int a = 0;
        static void Answer(int n)
        {
            string sb = string.Concat(Enumerable.Repeat("____", a));
            a++;
            Console.Write(sb);
            Console.Write("\"재귀함수가 뭔가요?\" \n");
            if (n >= 1)
            {
                Console.Write(sb);
                Console.Write("\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.\n");
                Console.Write(sb);
                Console.Write("마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.\n");
                Console.Write(sb);
                Console.Write("그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"\n");
                Answer(n - 1);
            }
            if (n == 0)
            {
                Console.Write(sb);
                Console.Write("\"재귀함수는 자기 자신을 호출하는 함수라네\"\n");
            }
            
            Console.Write(sb);
            Console.Write("라고 답변하였지.\n");

        }
    }
}
