using System;
using System.Text;

/*
본격적으로 for문 문제를 풀기 전에 주의해야 할 점이 있다. 
입출력 방식이 느리면 여러 줄을 입력받거나 출력할 때 시간초과가 날 수 있다는 점이다.
*/

namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            //갯수를 받는다.
            int count = int.Parse(Console.ReadLine());
            //갯수에 맞는 stringbuilder를 생성한다.
            StringBuilder sb_output = new StringBuilder(count);
            //stringbuilder의 input을 줄마다 읽어서 또다른 string builder에 넣어준다.
            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                int a = int.Parse(str.Split(' ')[0]);
                int b = int.Parse(str.Split(' ')[1]);
                sb_output.AppendLine((a + b).ToString());
            }
            //stringbuilder의 내용을 출력한다.
            Console.WriteLine(sb_output.ToString());
            Console.ReadLine();
        }
    }
}
