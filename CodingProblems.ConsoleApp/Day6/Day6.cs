using System;
using System.Runtime.InteropServices;

namespace CodingProblems.ConsoleApp;

public class Day6
{
    // Count no. of occurrences (or frequency) in a sorted array 
    #region using Linear Search
    // Time Complexity  : O(N)
    // Space Complexity : O(1)

    public static void LinearSearch(int[] arr, int target){
        int res = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == target)
                res++;
        }
        Console.WriteLine("Count is: "+res);
    }
    #endregion

    #region using Binary Search
    // Time Complexity  : O(Log N)
    // Space Complexity : O(1)

    // Function to return Lower Bound
    static int LowerBound(int[] arr, int target) {
        int res = arr.Length;
        
        // Search space for binary search
        int lo = 0, hi = arr.Length - 1;

        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            if (arr[mid] >= target) {
                res = mid;
                hi = mid - 1;
            } 
              else {
                lo = mid + 1;
            }
        }
        return res;
    }

    // Function to return Upper Bound
    static int UpperBound(int[] arr, int target) {
        int res = arr.Length;
        
        int lo = 0, hi = arr.Length - 1;

        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            if (arr[mid] > target) {
                res = mid;
                hi = mid - 1;
            } 
              else {
                lo = mid + 1;
            }
        }
        return res;
    }

    public static void CountFreq(int[] arr, int target) {
        int count = UpperBound(arr, target) - LowerBound(arr, target);
        Console.WriteLine("Count is: "+count);
    }

    #endregion 
}