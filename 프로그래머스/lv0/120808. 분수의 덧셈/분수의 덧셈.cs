using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int nOne = numer1 * denom2;
        int nTwo = numer2 * denom1;
        int nSum = nOne + nTwo;
        int dCommon = denom1 * denom2;
        int num = 0;
        
        for (int i = 1; i <= dCommon; ++i)
        {
            if (nSum % i == 0 && dCommon % i == 0)
            {
                num = i;
            }
        }
        
        int[] result = {nSum / num, dCommon / num};
            
        return result;
    }
}