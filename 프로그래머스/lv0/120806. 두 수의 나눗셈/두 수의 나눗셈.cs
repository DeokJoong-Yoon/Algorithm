using System;

public class Solution {
    public int solution(int num1, int num2) {
            float numOne = (float)num1;
            float numTwo = (float)num2;
            float resultDouble = numOne / numTwo;
        
        return (int)(resultDouble * 1000);
    }
}