using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] reArray = new int[num2 - num1 + 1];
        
        for (int index = num1; index <= num2; ++index)
        {
            reArray[index - num1] = numbers[index];
        }
        
        return reArray;
    }
}