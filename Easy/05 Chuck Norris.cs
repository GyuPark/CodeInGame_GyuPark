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

//https://www.ascii-code.com/ 아스키 문자 리스트

class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        //Console.Error.WriteLine(MESSAGE);

        var startingNumber = 32; //필요한 ASCII Code 시작 숫자
        var endingNumber = 127; //필요한 ASCII Code 끝 숫자
        var arraySize = endingNumber - startingNumber + 1; //key와 value를 각각 담을 array들의 크기

        //key ( symbol ) 저장할 array
        string[] symbols_in_string = new string[arraySize];
        for (int i = startingNumber; i <= endingNumber; i++)
        {
            symbols_in_string[i - startingNumber] = (char)i.ToString(); //ASCII 문자를 인코딩해서 배열의 처음부터 차곡차곡 넣어준다.
        }

        //value ( binary ) 저장할 array
        string[] values_in_binary = new string[arraySize]; //배열에 32부터 127까지 이진법으로 표현한 숫자를 문자열 형식으로 담기.
        for (int i = 0; i < values_in_binary.Length; i++)
        {
            //keys_in_binary[i] = decimal 에서 binary로 변환한 걸 string으로 저장

        }

        //key로는 ASCII문자를 담고, value로는 해당 ascii문자의 index 숫자의 이진법 형식(문자열)을 담는다.
        Dictionary<string, string> symbolForBinary = new Dictionary<string, string>();

        //Dictionary key-value 형태로 넣어주기
        for (int i = 0; i < arraySize; i++)
        {
            symbolForBinary.Add(symbols_in_string[i], values_in_binary[i]);
        }

        //MESSAGE를 이진법으로 encoding하기
        //ChuckNorris' technique으로 encoding하기
        //encoding 한 걸 출력하기

        var answer = "";
        Console.WriteLine(answer);
    }
}