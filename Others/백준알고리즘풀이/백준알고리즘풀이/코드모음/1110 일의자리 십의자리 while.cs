using System;

/*
1110 더하기사이클
*/

namespace 백준알고리즘풀이
{
    class Program
    {
        static void Main(string[] args)
        {
            //input을 받아서 int형식으로 변환한다.
            int input = int.Parse(Console.ReadLine());
            //input의 10의 자리는 a, 1의 자리는 b라고 한다.
            int inputA = input / 10;
            int inputB = input % 10;

            int tempA = inputA;
            int tempB = inputB;
            int count = 0;

            do
            {
                //count는 1추가된다.
                count++;

                //10의 자리와 1의 자리 숫자를 더한 결과에서 일의 자리만 얻는다.
                int temp = (tempA + tempB) % 10;
                //이전 숫자의 1의 자리는 십의 자리가 된다. 새로 얻은 일의 자리는 새 숫자의 일의 자리가 된다.
                tempA = tempB;
                tempB = temp;

                //Console.WriteLine(count);
                //Console.WriteLine(tempA * 10 + tempB);

            //현재 숫자가 처음 숫자와 같지 않다면, 작업은 반복된다
            } while (!(tempA == inputA && tempB == inputB));

            //모든 작업이 끝나면 사이클의 길이를 출력한다.
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
