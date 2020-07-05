using System;

/*
10952
A + B - 5
*/

namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop를 깨지 않는 한 계속 반복된다.
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                if ((a + b) != 0)
                {
                    Console.WriteLine(a + b);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
