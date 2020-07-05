using System;

/*
10951
A + B 끝에 아무것도 없을 때.. 안되는 이유?
*/

namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //user input을 받아온다.
                //string input = Console.ReadLine();
                string[] input = Console.ReadLine().Split(' '); //있지도 않은 라인은 쪼갤 수 없다!! 그래서 런타임 에러 발생함.
                //user input이 존재하면,
                if (input == null)
                {
                    break;
                }
                else
                {
                    //A와 B를 추출한다
                    //int a = int.Parse(input.Split(' ')[0]);
                    //int b = int.Parse(input.Split(' ')[1]);
                    int a = int.Parse(input[0]);
                    int b = int.Parse(input[1]);
                    //A 와 B를 더한 값을 출력한다.
                    Console.WriteLine(a + b);
                }
            }
        }   
    }
}
