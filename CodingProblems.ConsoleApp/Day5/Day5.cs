using System;

namespace CodingProblems.ConsoleApp;

public class Day5
{
    public static void SortArrayAsWave(int[] arr){
        #region Naive Approach
        // Time Complexity  : O(N log N)
        // Space Complexity : O(1)

        int n = arr.Length;
        Array.Sort(arr);
        // Swap adjacent elements
        for (int i = 0; i < n - 1; i += 2){
            Swap(arr, i, i + 1);
        }

        Console.WriteLine("Array in wave form is:");
        for (int i = 0; i < n; i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        #endregion

        #region Efficient Approach
        // Time Complexity  : O(N)
        // Space Complexity : O(1)

        for (int i = 0; i < n; i += 2) {
            
            if (i > 0 && arr[i - 1] > arr[i])
                Swap(arr, i - 1, i);

            if (i < n - 1 && arr[i] < arr[i + 1])
                Swap(arr, i, i + 1);
        }

        Console.WriteLine("Array in wave form is:");
        for (int i = 0; i < n; i++){
            Console.Write(arr[i] + " ");
        }

        #endregion

        // A utility method to swap two numbers.
    
    }
    static void Swap(int[] arr, int a, int b)
    {
        (arr[b], arr[a]) = (arr[a], arr[b]);
    }
}
