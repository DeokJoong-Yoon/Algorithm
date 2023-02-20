using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[strlist.Length];
        for (int index = 0; index < strlist.Length; ++index)
        {
            answer[index] = strlist[index].Length;
        }
        return answer;
    }
}