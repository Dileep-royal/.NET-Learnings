using System;

namespace CodingProblems.ConsoleApp.Day4;

public class Day4
{
    public static void MajorityElement(int[] arr){
        #region Naive Approach
        // Time Complexity  : O(N)
        // Space Complexity : O(1)

        int n = arr.Length; 
        
        for (int i = 0; i < n; i++) {
            int count = 0;

            for (int j = 0; j < n; j++) {
                if (arr[i] == arr[j]) {
                    count++;
                }
            }

            if (count > n / 2) {
                Console.WriteLine("Majority Element : "+arr[i]);
                return;
            }
        }
        Console.WriteLine("No Majority Element");

        #endregion

        #region By Sorting and check consecutive same element pairs count
        // Time Complexity  : O(N log N)
        // Space Complexity : O(1)
        
        if (n == 1){
            Console.WriteLine("Majority Element : "+arr[0]);
            return;
        }

        int cnt = 1;
        Array.Sort(arr); 

        for (int i = 1; i < n; i++) {
            if (arr[i - 1] == arr[i]) {
                cnt++;
            } else {
                if (cnt > n / 2) {
                    Console.WriteLine("Majority Element : "+arr[i-1]);
                    return;
                }
                cnt = 1;
            }
        }

        if (cnt > n / 2) {
            Console.WriteLine("Majority Element : "+arr[n-1]);
            return;
        }

        Console.WriteLine("No majority element found");
    

        #endregion


        #region Using Dictionary
        // Time Complexity  : O(N)
        // Space Complexity : O(N)

        Dictionary<int, int> countMap = new Dictionary<int, int>();

        foreach (int num in arr) {
            if (countMap.ContainsKey(num))
                countMap[num]++;
            else
                countMap[num] = 1;

            if (countMap[num] > n / 2) {
                Console.WriteLine("Majority Element : "+num);
                return;
            }
        }

        Console.WriteLine("No majority element found ");
        #endregion

        #region Moore's Voting Algorithm
        // Time Complexity  : O(N)
        // Space Complexity : O(1)

        int candidate = -1;
        int count1 = 0;

        foreach (int num in arr) {
            if (count1 == 0) {
                candidate = num;
                count1 = 1;
            } else if (num == candidate) {
                count1++;
            } else {
                count1--;
            }
        }

        // Validate the candidate
        int count2 = 0;
        foreach (int num in arr) {
            if (num == candidate) {
                count2++;
            }
        }
    
        if (count2 > n / 2) {
            Console.WriteLine("Majority Element : "+candidate);
        } else {
            Console.WriteLine("No Majority Element found");
        }
        
        #endregion
    }
}
