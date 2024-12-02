using System;

namespace CodingProblems.ConsoleApp;

public class Day9
{
    // Maximum Subarray Sum

    #region Naive Approach
    // Time Complexity  : O(N^2)
    // Space Complexity : O(1)

    public static void MaxSubarraySum(int[] arr) {
        int res = arr[0];
  
        for (int i = 0; i < arr.Length; i++) {
            int currSum = 0;

            for (int j = i; j < arr.Length; j++) {
                currSum += arr[j];
              
                res = Math.Max(res, currSum);
            }
        }
        Console.WriteLine("Maximum Subarray Sum is: "+res);
    }

    #endregion

    #region Using Kadane's Algorithm
    // Time Complexity  : O(N)
    // Space Complexity : O(1)

    public static void MaxSubarraySum1(int[] arr) {
        int res = arr[0];
        int maxEnding = arr[0];

        for (int i = 1; i < arr.Length; i++) {

            maxEnding = Math.Max(maxEnding + arr[i], arr[i]);
            
            res = Math.Max(res, maxEnding);
        }

        Console.WriteLine("Maximum Subarray Sum is: "+res);
    }

    #endregion

}
