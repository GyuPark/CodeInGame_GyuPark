using System;

namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input을 공백으로 쪼갠 후, 조각들을 string형식 배열에 담는다.
            string[] input = Console.ReadLine().Split();
            //쪼갠 것들을 꺼내어 int로 변환하고 더해버린다.
            int result = int.Parse(input[0]) + int.Parse(input[1]);
            //더한 결과를 출력한다.
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
