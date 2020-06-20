using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');

        int closestNumber = n == 0 ? 0 : int.MaxValue;

        for (int i = 0; i < n; i++)
        {

            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526

            //절댓값이 같다면, 양수인지 확인한다. 양수라면 closestNumber를 갱신한다.
            if (Math.Abs(t) == Math.Abs(closestNumber))
            {
                if (t > 0)
                {
                    closestNumber = t;
                }
            }
            //절댓값이 closestNumer보다 작다면, closestNumber를 갱신한다.
            else if (Math.Abs(t) < Math.Abs(closestNumber))
            {
                closestNumber = t;
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(closestNumber);
    }
}