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

        int currentTx = initialTx; //현재 위치를 담는 변수 초기화
        int currentTy = initialTy; //현재 위치를 담는 변수 초기화


        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            var dir = ""; //방향 변수 초기화

            var displacementX = lightX - currentTx; //현재 위치에서 lightX까지의 x거리
            var displacementY = lightY - currentTy; //현재 위치에서 lighty까지의 y거리

            //수평 수직이동
            if (Math.Abs(displacementX) != Math.Abs(displacementY))
            {
                if ()
                {

                }
                else if ()
                {

                }
                else if ()
                {

                }
                else
                {

                }
            }
            // - 같다면 대각선 이동한다.
            else
            {
                //NE
                if ()
                {

                }
                //SE
                else if ()
                {

                }
                //SW
                else if ()
                {

                }
                //NW
                else
                {

                }
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(dir);
        }
    }


}

/*
전략 : 
1. 매 turn마다 현재 pos를 알 수 있어야 한다.
2. lightX - currentTx == 0 혹은 lightY - currentTy == 0 이라면, 수직 혹은 수평이동이다.
3. 그렇지 않다면, 삼각형 이동이다.
4.  - a 와 b의 길이를 비교하여 긴쪽으로 짧게 맞춘다.
5.  - a 와 b의 길이가 같다면, 대각선 이동한다.
*/
