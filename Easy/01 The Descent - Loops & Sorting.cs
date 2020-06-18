using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            //가장 높은 산 index를 저장할 변수
            var maxHeightIndex = 0;
            //각장 높은 산의 height를 저장할 변수
            var maxHeight = 0;

            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                //maxHeight보다 지금 비교하는 산이 더 높다면
                if (mountainH > maxHeight)
                {
                    //새로운 높이가 갱신되고
                    maxHeight = mountainH;
                    //새로운 산의 index도 갱신된다.
                    maxHeightIndex = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(maxHeightIndex); // The index of the mountain to fire on.

        }
    }
}