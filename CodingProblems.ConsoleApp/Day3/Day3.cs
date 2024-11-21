using System;

namespace CodingProblems.ConsoleApp;

public class Day3
{

    public static void FindMinAndMax(int[] arr){
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>max) max = arr[i];
            if(arr[i]<min) min = arr[i];
        }
        Console.WriteLine($"Minimum element is: {min} and Maximum element is:{max}");
    }

    // Sort an array of 0s, 1s and 2s
    public static void SortAnArrayOfOnes_Twos_AndThrees(int[] arr){
        
        #region Naive Approach
        // Time Complexity  : O(2*N) ~ O(N)
        // Space Complexity : O(1)


        int c0 = 0, c1 = 0, c2 = 0;
        
        // Count 0s, 1s and 2s
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == 0) 
                c0 += 1;
            else if (arr[i] == 1) 
                c1 += 1;
            else 
                c2 += 1;
        }

        int idx = 0;

        // update arr with 0s
        for (int i = 0; i < c0; i++)
            arr[idx++] = 0;

        // update arr with 1s
        for (int i = 0; i < c1; i++)
            arr[idx++] = 1;

        // update arr with 2s
        for (int i = 0; i < c2; i++)
            arr[idx++] = 2;

        Console.WriteLine("Array after sorting: ");
        foreach (int item in arr)
        {
            Console.Write(item+" ");
        }
            Console.WriteLine();

        #endregion

        #region Efficient Approach
        // Time Complexity  : O(N)
        // Space Complexity : O(1)
        int n = arr.Length;
        int low = 0;
        int high = n - 1;
        int mid = 0;

        while (mid <= high) {
            if (arr[mid] == 0) {
                Swap(arr, low, mid);
                low++;
                mid++;
            }
            else if (arr[mid] == 1) {
                mid++;
            }
            else {
                Swap(arr, mid, high);
                high--;
            }
        }

        Console.WriteLine("Array after sorting: ");
        foreach (int item in arr)
        {
            Console.Write(item+" ");
        }
            Console.WriteLine();
        #endregion
    }

    static void Swap(int[] arr, int i, int j) {
        (arr[j], arr[i]) = (arr[i], arr[j]);
    }
}
