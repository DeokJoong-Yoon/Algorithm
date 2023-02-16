using System;

public class Solution {
    public int solution(int[] array) {
        int tmp;
        
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j + 1];
                        array[j + 1] = array[i=j];
                        array[j] = tmp;
                    }
                }
            }
        
        return array[(array.Length) / 2];
    }
}