using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTrackerTests
  {
    [TestMethod]
    public void Is_Word_A_Palindrome()
    {
      PalindromeTracker tracker = new PalindromeTracker();
      Assert.AreEqual(true, tracker.IsWordAPalindrome("racecar"));
    }
  }
}
