using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer = new int[] { };

        //arr와 동일한 list를 하나 만들어준다.
        List<int> arr_List = new List<int>();
        //arr의 요소들을 arr_List에 넣어준다.
        for (int i = 0; i < arr.Length; i++)
        {
            arr_List.Add(arr[i]);
        }


        //arr_List의 element들 중 가장 작은 element를 찾는다.
        int min = arr_List[0]; // - 최소값을 담을 변수 초기화
        int min_idx = 0; // - 최소값의 index를 담을 변수 초기화

        for (int i = 0; i < arr_List.Count; i++)
        {
            //min보다 작은 수를 발견하면,
            if (arr_List[i] < min)
            {
                //min과 min_idx를 갱신한다.
                min = arr_List[i];
                min_idx = i;
            }
        }

        //이 모든 게 끝나면,
        //arr_List에서 가장 작은 element를 제거한다.
        arr_List.RemoveAt(min_idx);

        //제거 후 arr의 길이를 확인하여 빈 배열이면 -1을 넣어 answer에 담고, 그렇지 않으면 arr_List를 그대로 answer에 담는다.
        if (arr_List.Count == 0)
        {
            arr_List.Add(-1);
        }

        answer = arr_List.ToArray();

        return answer;
    }
}