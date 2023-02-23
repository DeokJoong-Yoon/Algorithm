using System;

public class Solution {
    public int solution(int[] sides) {
        int max = sides[0];
        int maxIndex = 0;
        for (int i = 1; i < sides.Length; ++i)
        {
            if (max < sides[i])
            {
                max = sides[i];
                maxIndex = i;
            }
        }
        
        int[] line = new int[2];
        int j = 0;

        for (int i = 0; i < sides.Length; ++i)
        {
            if (i != maxIndex)
            {
                line[j] = sides[i];
                ++j;
            }
         }
        
        if (max < line[0] + line[1])
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}