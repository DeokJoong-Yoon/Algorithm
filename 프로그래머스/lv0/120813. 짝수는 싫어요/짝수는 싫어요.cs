using System;

public class Solution {
    public int[] solution(int n) {
        int oddCount = 0;
        
        for (int index = 1; index <= n; ++index)
        {
            if (index % 2 == 1)
            {
                ++oddCount;
            }
        }
        
        int[] oddArray = new int[oddCount];
        int oddIndex = 0;
        for (int index = 1; index <= n; ++index)
        {
            if (index % 2 == 1)
            {
                oddArray[oddIndex] = index;
                ++oddIndex;
            }
        }
        
        return oddArray;
    }
}