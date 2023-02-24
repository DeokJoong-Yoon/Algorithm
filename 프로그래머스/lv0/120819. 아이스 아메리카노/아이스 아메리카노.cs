using System;

public class Solution {
    public int[] solution(int money) {
        const int iceAmericano = 5500;
        int cups = 0;
        
        cups = money / iceAmericano;
        money = money - cups * iceAmericano;
        
        int[] result = new int[2] { cups, money };
        
        return result;
        
    }
}