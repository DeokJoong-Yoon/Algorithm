using System;

public class Solution {
    public int solution(string my_string) {
        char[] my_chars = new char[my_string.Length];

        int result = 0;
        for (int i = 0; i < my_chars.Length; ++i)
        {
            my_chars[i] = my_string[i];
        }

         for (int i = 0; i < my_chars.Length; ++i)
        {
            if ((int)Char.GetNumericValue(my_chars[i]) >= 0)
            {
                result += (int)Char.GetNumericValue(my_chars[i]);
            }
        }
        return result;
    }
}