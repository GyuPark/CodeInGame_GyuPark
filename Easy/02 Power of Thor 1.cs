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

        // - initial displacement 계산
        int displacementX = lightX - initialTx;
        int displacementY = lightY - initialTy;

        //current Thor position variables
        int currentTx = 0;
        int currentTy = 0;

        //current displacement of Thor from Light
        int currentDisplacementX = 0;
        int currentDisplacementY = 0;

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            var dir = "";



            // 8방중 한 방향
            Console.WriteLine(dir);
        }
    }
}