using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int stringCount = 0;
        
        for (int s1Index = 0; s1Index < s1.Length; ++s1Index)
        {
            for (int s2Index = 0; s2Index < s2.Length; ++s2Index)
            {
                if (s1[s1Index] == s2[s2Index])
                {
                    ++stringCount;
                }
            }
        }
        
        return stringCount;
    }
}