using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTrackerTests
  {
    [TestMethod]
    public void IsWord_APalindrome_True()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(true, tracker.IsWordAPalindrome("racecar"));
    }
    [TestMethod]
    public void IsNumber_APalindrome_True()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(true, tracker.IsWordAPalindrome("101"));
    }
    [TestMethod]
    public void IsWord_NotAPalindrome_True()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(true, tracker.IsWordAPalindrome("horse"));
    }

    [TestMethod]
    public void IsWord_BlankInput_False()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(false, tracker.IsWordAPalindrome(""));
    }

    [TestMethod]
    public void IsWord_WithDifferentCasesPalindrome_True()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(true, tracker.IsWordAPalindrome("rAceCar"));
    }
  }
}

// is rAceCar
// IsLeapYear_NumberNotDivisibleByFour_False