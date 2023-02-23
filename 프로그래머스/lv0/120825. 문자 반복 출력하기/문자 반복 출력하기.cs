using System;

public class Solution {
    public string solution(string my_string, int n) {
        char[] stringToChar = my_string.ToCharArray();
        char[] threeTimesChar = new char[n * stringToChar.Length];
        int index = 0;
        for (int i = 0; i < stringToChar.Length; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                threeTimesChar[index] = stringToChar[i];
                ++index;
            }
        }
        
        return String.Concat(threeTimesChar);
    }
}