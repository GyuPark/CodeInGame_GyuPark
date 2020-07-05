using System;
using System.Collections.Generic;

/*
10871
정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 
이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
*/
namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //N과 X를 받아서 따로 int 변수에 저장한다.
            string[] input_NX = Console.ReadLine().Split(' ');
            int n = int.Parse(input_NX[0]);
            int x = int.Parse(input_NX[1]);
            //sequence A를 받아서 정수배열로 저장한다.
            string[] input_A = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(input_A, new Converter<string, int>(stringToInt));

            //A의 element들과 X를 비교하여, X보다 작은 수는 문자열 변수에 더한다.
            string temp = "";
            foreach (var item in A)
            {
                if (item < x)
                {
                    temp += item+" ";
                }
            }

            //마지막으로 문자열 변수를 출력한다.
            Console.WriteLine(temp);
        }

        // Defining the method 
        // intToString 
        public static int stringToInt(string pf)
        {
            return int.Parse(pf);
        }
    }
}
