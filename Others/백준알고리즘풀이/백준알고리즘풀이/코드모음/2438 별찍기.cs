using System;
using System.Text;

/*
2438
별 찍기
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
            //1부터 N까지의 별을 각각 다른 줄로 추가한다.
            for (int i = 1; i <= n; i++)
            {
                string temp = "";
                for (int j = 0; j < i; j++)
                {
                    temp += "*";
                }
                sb.AppendLine(temp);
            }
            //Stringbuilder를 출력한다.
            Console.WriteLine(sb.ToString());
        }
    }
}
