using System;
using System.Runtime.InteropServices;

namespace CodingProblems.ConsoleApp;

public class Day7
{
    // K’th Smallest Element in Unsorted Array
    #region Naive Approach
    // Time Complexity  : O(N log N)
    // Space Complexity : O(1)
    public static void KthSmallest(int[] arr, int K){
        Array.Sort(arr);
        Console.WriteLine($"{K}th smallest element is:"+arr[K - 1]);
    }
    #endregion

}
