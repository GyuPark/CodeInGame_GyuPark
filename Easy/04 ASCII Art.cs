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

        Console.Error.WriteLine("L : " + L);
        Console.Error.WriteLine("H : " + H);
        Console.Error.WriteLine("T : " + T);

        //T 철자의 알파벳 순서들을 담을 배열 생성
        int[] indexForEachTElement = new int[T.Length];

        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?";
        string lowerCase = "abcdefghijklmnopqrstuvwxyz?";

        //ASCII art를 글자마다 그리고 줄마다 나눠 저장할 2차원 배열을 만든다.
        //H by 27인 이유는, 알파벳이 26자이고 물음표가 추가되어 있기 때문이다.
        string[,] artSeparatedByLine = new string[H, 27];

        //ROW에 담기는 데이터를 2차원 배열에 저장하는데,
        //행 갯수인 H와 부호 갯수 27를 곱해 H X 27 배열을 만든다.
        //즉, 부호마다 H개의 행으로 나눠서 저장된다.
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

        //T를 철자마다 분석하여 upperCase와 lowerCase에 해당되는지 확인한다. 없으면 26로 추가된다.
        for (int i = 0; i < indexForEachTElement.Length; i++)
        {
            //upperCase에 있다면?
            if (GetStringIndex(upperCase, T[i].ToString()) != 100)
            {
                indexForEachTElement[i] = GetStringIndex(upperCase, T[i].ToString());
            }
            //lowerCase에 있다면?
            else if (GetStringIndex(lowerCase, T[i].ToString()) != 100)
            {
                indexForEachTElement[i] = GetStringIndex(lowerCase, T[i].ToString());
            }
            //아무 곳에도 없다면? 26
            else
            {
                indexForEachTElement[i] = 26;
            }
        }

        //ASCII ART를 만들어보자
        for (int i = 0; i < H; i++)
        {
            var str = "";

            for (int j = 0; j < indexForEachTElement.Length; j++)
            {
                str += artSeparatedByLine[i, indexForEachTElement[j]];
            }

            Console.WriteLine(str);
        }
    }

    static int GetStringIndex(string wholeString, string query)
    {
        //default 값을 100으로 준다. wholeString에서 query를 찾지 못하였을 때 100을 반환한다.
        int index = 100;

        for (int i = 0; i < wholeString.Length; i++)
        {
            if (wholeString[i].ToString() == query) //Char과 String형식은 비교될 수 없다...
            {
                index = i;
                break;
            }
        }

        return index;
    }

    /// <summary>
    /// returns a snippet of the given string, starting at startIdx and ending at endIdx
    /// </summary>
    /// <param name="wholeString"></param>
    /// <param name="startIdx"></param>
    /// <param name="endIdx"></param>
    /// <returns></returns>
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