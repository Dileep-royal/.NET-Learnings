using System;

namespace CodingProblems.ConsoleApp;

public class Day8
{
    // K’th Smallest Element in Unsorted Array

    #region Using Priority Queue
    // Time Complexity  : O(N log K)
    // Space Complexity : O(K)

    public static void KthSmallest(int[] arr, int K){

        var maxHeap = new SortedSet<int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var num in arr)
        {
            maxHeap.Add(-num);

            if (maxHeap.Count > K)
                maxHeap.Remove(maxHeap.Max);
        }

        Console.WriteLine($"{K}th smallest element is:"+-maxHeap.Max);
    }
    #endregion
}
