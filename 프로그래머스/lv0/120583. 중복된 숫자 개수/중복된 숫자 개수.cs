using System;

public class Solution {
    public int solution(int[] array, int n) {
        int nCount = 0;
        
        for (int index = 0; index < array.Length; ++index)
        {
            if (array[index] == n)
            {
                ++nCount;
            }
        }

        return nCount;
    }
}