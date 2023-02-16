using System;

public class Solution {
    public int solution(int slice, int n) {
        
        for (int i = 0; i <= n; ++i)
        {
            int c = slice * i / n;
            if (c >= 1)
            {
                return i;
            }
        }
        return slice;
    }
}