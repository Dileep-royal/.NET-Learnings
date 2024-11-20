using System;
using System.Security.Cryptography;
using System.Text;

namespace CodingProblems.ConsoleApp;

public class Day1
{
    public static void FirstNon_RepeatingCharacter(string input){
      #region Naive Approach
        // Time Complexity  : O(N^2)
        // Space Complexity : O(N)

        bool found= false;
        for (int i = 0; i < input.Length; i++)
        {
          bool repeated = false;
          for(int j =0; j < input.Length; j++){
            if(input[i] == input[j] && i!=j){
              repeated = true;
              break;
            }
          }
          if(!repeated){
            Console.WriteLine("First non-repeating character is: "+input[i]);
            found = true;
            break;
          }
        }
        if(!found){
            Console.WriteLine("Non-repeating character not found");
        }

      #endregion

      #region Using Frequency array
      // Time Complexity  : O(N)
      // Space Complexity : O(N)

      const int MAX_CHAR = 26;
      char[] freq = new char[MAX_CHAR];

      // first travel to read the frequencies
      foreach(Char ele in input){
        freq[ele-'a']++;
      }

      bool found1 = false;
      foreach (var ele in input)
      {
        if(freq[ele-'a'] == 1){
          Console.WriteLine("First non-repeating character is: "+ele);
          found1 = true;
          break;
        }
      }

      if(!found1) Console.WriteLine("Non-repeating character is not found");

      #endregion
    }

    public static void IsPalindrome(string input){
        #region Naive Approach
        // Time Complexity  : O(N)
        // Space Complexity : O(N)
        
        string reverse = string.Empty;
        for (int i = input.Length-1; i >= 0; i--)
        {
          reverse+=input[i];
        }

        if(input.Equals(reverse)){
          Console.WriteLine($"Given string: {input} is a Palindrome");
        }
        else{
          Console.WriteLine($"Given string: {input} is not a Palindrome");
        }

        #endregion

        # region Two pointer Approach
        // Time Complexity  : O(N/2) ~ O(N)
        // Space Complexity : O(1)

        int j = input.Length-1;
        bool flag = true;
        for (int i = 0; i <= j/2; i++)
        {
          if(input[i]!=input[j--]){
            flag = false;
            break;
          }
        }
        if(flag){
          Console.WriteLine($"Given string: {input} is a Palindrome");
        }
        else{
          Console.WriteLine($"Given string: {input} is not a Palindrome");
        }     
        #endregion

        #region Using LINQ
        // Time Complexity  : O(N)
        // Space Complexity : O(N)

        String str1 = new String(input.Reverse().ToArray());
        if(input.Equals(str1)){
          Console.WriteLine($"Given string: {input} is a Palindrome");
        }
        else{
          Console.WriteLine($"Given string: {input} is not a Palindrome");
        }
        #endregion

    }
}
