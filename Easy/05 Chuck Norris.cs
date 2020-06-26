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
        Console.Error.WriteLine(MESSAGE);

        var startingNumber = 32; //필요한 ASCII Code 시작 숫자
        var endingNumber = 127; //필요한 ASCII Code 끝 숫자
        var arraySize = endingNumber - startingNumber + 1;

        //어떤 자료구조가 좋을까? 물론 Dictionary... key = symbol : value = binary in string
        Dictionary<string, string> symbolForBinary = new Dictionary<string, string>();

        //value ( binary ) 저장할 컬랙션
        string[] values_in_binary = new string[arraySize]; //배열에 32부터 127까지 이진법으로 표현한 숫자를 문자열 형식으로 담기.
        for (int i = 0; i < values_in_binary.Length; i++)
        {
            //keys_in_binary[i] = decimal 에서 binary로 변환한 걸 string으로 저장
        }

        ////key ( symbol ) 저장할 컬랙션
        //var symbols = "";
        //for (int i = startingNumber; i <= endingNumber; i++) //ASCII 문자를 인코딩해서 넣어주기
        //{
        //    symbols += (char)i; //인코딩
        //    //Console.Error.WriteLine(symbols);
        //}
        //string[] symbols_in_string = symbols.Split(); //안될듯

        //key ( symbol ) 저장할 컬랙션
        string[] symbols_in_string = new string[arraySize];
        for (int i = startingNumber; i <= endingNumber; i++) //ASCII 문자를 인코딩해서 넣어주기
        {
            symbols_in_string[i - startingNumber] = (char)i.ToString();
        }

        //Dictionary key-value 설정하기
        for (int i = 0; i < arraySize; i++)
        {
            symbolForBinary.Add(symbols_in_string[i], values_in_binary[i]);
        }

        Console.WriteLine("answer");
    }
}