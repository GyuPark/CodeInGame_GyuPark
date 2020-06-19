using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            //움직여야 할 방향
            var dir = "";

            //삼각형(h, a, b)을 그려서 8방 중 한 방향 정하기
            var displacementX = lightX - initialTx; //b
            var displacementY = lightY - initialTy; //a

            var angle = 0d;

            if (displacementX == 0)
            {
                if (displacementY < 0)
                {

                }
                else if (displacementY > 0)
                {

                }
            }
            else
            {
                angle = Math.Atan(displacementY / displacementX); //theta
            }

            Console.Error.WriteLine("Debug " + angle);

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(dir);
        }
    }
}