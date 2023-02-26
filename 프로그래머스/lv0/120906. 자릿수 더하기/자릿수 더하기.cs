using System;

public class Solution {
    public int solution(int n) {
        
        return Solution.RecursiveFunction(n);
    }
    static public int RecursiveFunction(int a)
    {
        int share = a / 10;
        int rest = a % 10;
        int sum = 0;
    
        sum += rest;
    
        if (share == 0)
        {
             return sum;
        }
    
        return RecursiveFunction(share) + sum;
    }
}
