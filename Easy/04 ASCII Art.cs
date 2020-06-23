using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();

        Console.Error.WriteLine("L is : " + L);
        Console.Error.WriteLine("H is : " + H);

        //T를 철자마다 나눠서 배열에 저장한다.
        string[] splitT = T.Split();

        //ASCII art를 글자마다 그리고 줄마다 나눠 저장할 2차원 배열을 만든다.
        //H by 27인 이유는, 알파벳이 26자이고 물음표가 추가되어 있기 때문이다.
        string[,] artSeparatedByLine = new string[H, 27];

        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();

            //글자별로 담기
            for (int j = 0; j < 27; j++)
            {
                int start = j * L;
                int end = start + L - 1;

                artSeparatedByLine[i, j] = GetStringSnippet(ROW, start, end);
            }
        }

        Console.Error.WriteLine(artSeparatedByLine[0, 26]);
    }

    //returns a snippet of the given string, starting at startIdx and ending at endIdx
    static string GetStringSnippet(string wholeString, int startIdx, int endIdx)
    {
        string str = "";

        for (int i = startIdx; i <= endIdx; i++)
        {
            str += wholeString[i];
        }

        return str;
    }
}