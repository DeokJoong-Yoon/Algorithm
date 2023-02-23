using System;

public class Solution {
    public string solution(string my_string, string letter) {
    
        my_string = my_string.Replace(letter, "");

        return my_string;
    }
}