using System;

namespace CodingProblems.ConsoleApp;

public class Day2
{
    public static void LongestCommonPrefix(string[] arr) {

        int minLen = arr[0].Length;

        foreach(string str in arr)
            minLen = Math.Min(minLen, str.Length);

        string res = "";

        for (int i = 0; i < minLen; i++) {
            char ch = arr[0][i];

            foreach (string str in arr) {
                if (str[i] != ch) {
                    Console.WriteLine("Longest common prefix is: "+res);
                    return;
                }
            }
            res += ch;
        }

        Console.WriteLine("Longest common prefix is: "+res); 
    }
}
