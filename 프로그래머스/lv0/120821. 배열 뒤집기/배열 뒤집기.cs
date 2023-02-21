using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] reverseArray = new int[num_list.Length];
        
        for (int index = 0; index < num_list.Length; ++index)
        {
            reverseArray[index] = num_list[num_list.Length - 1 - index];
        }
        
        return reverseArray;
    }
}