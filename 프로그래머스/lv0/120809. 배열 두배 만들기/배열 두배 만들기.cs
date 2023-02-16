using System;

public class Solution {
    public int[] solution(int[] numbers) {
        
        int[] numMultiply = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; ++i)
        {
            numMultiply[i] = 2 * numbers[i];
        }
        return numMultiply;
    }
}