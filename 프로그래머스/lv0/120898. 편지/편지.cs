using System;

public class Solution {
    public int solution(string message) {
        char[] messageToChar = message.ToCharArray();
        
        return messageToChar.Length * 2;
    }
}