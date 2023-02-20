using System;

public class Solution {
    public int solution(int n) {
        double result = n / 7.0;
        int answer = (int)(result + 0.9);
        return answer;
    }
}