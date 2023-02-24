using System;

public class Solution {
    public int solution(int[] numbers) {
        
        int[] maxNumbers = new int[2] { 0, 0 };
        int maxIndex = 0;
        for (int index = 0; index < numbers.Length; ++index)
        {
            if (maxNumbers[0] < numbers[index])
            {
                maxNumbers[0] = numbers[index];
                maxIndex = index;
            }
        }
        
        for (int index = 0; index < numbers.Length; ++index)
        {
            if (maxIndex != index && maxNumbers[1] < numbers[index])
            {
                maxNumbers[1] = numbers[index];
            }
        }
        
        return maxNumbers[0] * maxNumbers[1];
    }
}