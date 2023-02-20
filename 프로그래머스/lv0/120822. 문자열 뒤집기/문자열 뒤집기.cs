using System;

public class Solution {
    public string solution(string my_string) {
        char[] parseToString = my_string.ToCharArray();
        char[] reverseString = new char[my_string.Length];

        for (int index = 0; index < my_string.Length; ++index)
        {
            reverseString[index] = parseToString[my_string.Length - 1 - index];
        }
        my_string = new string(reverseString);
        return my_string;
    }
}