public class Solution
{
    public double solution(int[] arr)
    {
        double answer = 0;

        //arr의 모든 element answer에 더하기
        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        //arr의 크기로 나눠서 평균값 구하기
        answer /= arr.Length;

        return answer;
    }
}