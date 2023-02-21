using System;

public class Solution {
    public int solution(int[] array, int height) {
        int[] newArray = new int[array.Length + 1];
        int heightOrderCount = 0;
        for (int heightIndex = 0; heightIndex < array.Length; ++heightIndex)
        {
            if (array[heightIndex] > height)
            {
                ++heightOrderCount;
            }
        }
        return heightOrderCount;
    }
}