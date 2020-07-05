using System;

/*
ABC * DEF 출력하기
*/
namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            // ABC를 받아온다
            int abc = int.Parse(Console.ReadLine());
            // DEF를 받아온다
            int def = int.Parse(Console.ReadLine());

            // D,E,F를 각각 얻는다
            int d = def / 100;
            int e = (def - d * 100) / 10;
            int f = def - d * 100 - e * 10;

            // ABC * F를 출력한다
            Console.WriteLine(abc * f);
            // ABC * E를 출력한다
            Console.WriteLine(abc * e);
            // ABC * D를 출력한다
            Console.WriteLine(abc * d);
            // ABC * F + ABC * E * 10 + ABC * D * 100 을 출력한다.
            Console.WriteLine(abc * f + abc * e * 10 + abc * d * 100);

            Console.ReadLine();
        }
    }
}
