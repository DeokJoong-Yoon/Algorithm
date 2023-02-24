using System;

public class Solution {
    public int solution(int n) {
        int pairNumber1 = 1;
        int pairCount = 0;
        
        for (pairNumber1 = 1; pairNumber1 <= n; ++pairNumber1)
        {
            if (n % pairNumber1== 0)
            {
                ++pairCount;
            }
        }

        return pairCount;
    }
}