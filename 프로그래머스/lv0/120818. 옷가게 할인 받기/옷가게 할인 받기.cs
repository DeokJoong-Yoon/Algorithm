using System;

public class Solution {
    public int solution(int price) {
        double doublePrice = (double)price;
        
        if (price >= 500000)
        {
            doublePrice = doublePrice - doublePrice * 0.2;
        }
        else if (price >= 300000)
        {
            doublePrice = doublePrice - doublePrice * 0.1;
        }
        else if (price >= 100000)
        {
            doublePrice = doublePrice - doublePrice * 0.05;
        }
        else
        {
            return (int)doublePrice;
        }
        
        return (int)doublePrice;
    }
}