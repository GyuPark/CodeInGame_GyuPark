using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //take user input
            string[] input = Console.ReadLine().Split(' ');
            //a와 b에 각각 할당
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            //b에서 45를 뺀다
            b -= 45;
            //b가 음수라면, a에서 1을 뺀다. 그리고 b에 60을 더한다.
            if (b < 0)
            {
                a -= 1;
                b += 60;

                //a가 음수라면, a = 23이다.
                if (a <0)
                {
                    a = 23;
                }
            }

            Console.WriteLine(a.ToString() + ' ' + b.ToString());
            Console.ReadLine();
        }
    }
}
