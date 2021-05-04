using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class PalindromeTracker
  {
    public bool IsWordAPalindrome(string input)
    {
      if (input == "")
      {
        return false;
      }
      else
      {
        char[] letters = input.ToCharArray(0, input.Length);
        char[] returnLetters = letters;
        Array.Reverse(letters);
        return returnLetters == letters;
      }
    }
  }
}