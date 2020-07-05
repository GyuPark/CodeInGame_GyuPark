using System;
using System.Collections.Generic;

/// <summary>
/// 함수 solution은 정수 n을 매개변수로 입력받습니다. 
/// n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 
/// 예를들어 n이 118372면 873211을 리턴하면 됩니다.
/// </summary>
public class Solution
{
    public long solution(long n)
    {
        long answer = 0;

        //int 리스트에 숫자를 나눠 담는다.
        var str = n.ToString();
        List<int> list = new List<int>();
        for (int i = 0; i < str.Length; i++)
        {
            list.Add(int.Parse(str[i].ToString()));
        }

        var idx = 0;
        //담긴 숫자를 선택정렬한다.
        for (int i = 0; i < list.Count - 1; i++)
        {
            idx = i;

            for (int j = i + 1; j < list.Count; j++)
            {
                //만약 j 번째 element가 idx 보다 크다면,
                if (list[j] > list[idx])
                {
                    //idx을 list[j]로 갱신한다.
                    idx = j;
                }
            }

            //idx이 list[i]와 비교했을 때 갱신되었다면
            if (idx != i)
            {
                //list[i]와 list[idx]를 바꿔준다...
                var temp = list[idx];
                list[idx] = list[i];
                list[i] = temp;
            }
        }

        //새로운 숫자를 만들어 answer에 할당한다.
        var strr = "";
        foreach (var item in list)
        {
            strr += item;
        }
        answer = long.Parse(strr);
        return answer;
    }
}

/*
sorting 과 searching은 가장 많이 연구되는 알고리즘들이다.
많은 sorting 알고리즘들이 연구되었지만, 먼저 배워야할 sorting은 다음과 같다 : insertion, bubble, selection (순서상관없다).
이 sorting 알고리즘들은 큰 데이터보다는 비교적 작은 데이터를 처리하기에 적합하다.
Selection > Bubble > Insertion순으로 효율적이다. 이들 말고 Heap, Merge, Quick 도 있다. 

배운점 
1. string[] strArr = "ASDFASDFASDF".Split()은 불가하다..
2. 정렬은 element가 아니라 index로 처리한다..
3. long 을 int로 취급하지 않는다. 마지막에 int.Parse를 쓴게 문제가 되었다. long.Parse(strr)을 쓰니 문제가 없어졌다.
*/
