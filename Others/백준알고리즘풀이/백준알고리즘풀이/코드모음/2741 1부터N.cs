using System;
using System.Text;

/*
2741
자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
*/
namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //자연수 N을 받는다.
            int n = int.Parse(Console.ReadLine());
            //size N의 Stringbuilder를 생성한다.
            StringBuilder sb = new StringBuilder(n);
            //1부터 N까지의 숫자를 각각 다른 줄로 추가한다.
            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(i.ToString());
            }
            //Stringbuilder를 출력한다.
            Console.WriteLine(sb.ToString());
        }
    }
}
