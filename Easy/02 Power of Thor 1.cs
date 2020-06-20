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
            var absDisplacementX = Math.Abs(displacementX); //displacementX의 절대값
            var absDisplacementY = Math.Abs(displacementY); //displacementY의 절대값

            //a와 b의 길이가 같지 않다면 수평/수직이동 한다.
            if (absDisplacementX != absDisplacementY)
            {
                //X축으로 먼저 이동
                if (absDisplacementX > absDisplacementY)
                {
                    if (displacementX > 0)
                    {
                        dir = "E";
                        currentTx++;
                    }
                    else
                    {
                        dir = "W";
                        currentTx--;
                    }

                }
                //y축으로 먼저 이동
                else
                {
                    if (displacementY > 0)
                    {
                        dir = "S";
                        currentTy++;
                    }
                    else
                    {
                        dir = "N";
                        currentTy--;
                    }
                }
            }
            // a 와 b가 같으면 직각 이등변 삼각형이므로 빗변을 따라 대각선 이동한다.
            else
            {
                //NE
                if (displacementX > 0 && displacementY < 0)
                {
                    dir = "NE";
                    currentTx++;
                    currentTy--;
                }
                //SE
                else if (displacementX > 0 && displacementY > 0)
                {
                    dir = "SE";
                    currentTx++;
                    currentTy++;
                }
                //SW
                else if (displacementX < 0 && displacementY > 0)
                {
                    dir = "SW";
                    currentTx--;
                    currentTy++;
                }
                //NW
                else
                {
                    dir = "NW";
                    currentTx--;
                    currentTy--;
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
