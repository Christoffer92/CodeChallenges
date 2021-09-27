using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChallenge;

namespace PalindromeTest
{
    [TestClass]
    public class IsPalindromeTestClass {

        [TestMethod]
        [DataRow("dog", false)]
        [DataRow("racecar", true)]
        [DataRow("raceca@r", true)]
        [DataRow("r!ac!!eca@r", true)]
        [DataRow("stack cats", true)]
        [DataRow("stackcats", true)]
        [DataRow("aaa", true)]
        [DataRow("aaaa", true)]
        [DataRow("a", true)]
        [DataRow("dog", false)]
        public void IsPalindromeTest(string word, bool expectedBool) {
            //PREPARE
           // ConsoleAppPalindrome consoleAppPalindrome = new ConsoleAppPalindrome();

            //ACT
            bool actualBool = ConsoleAppPalindrome.IsPalindrome(word);

            //ASSERT
            Assert.AreEqual(expectedBool, actualBool, word);
        }

        [TestMethod]
        [DataRow(55055, true)]
        [DataRow(5555, true)]
        [DataRow(32, false)]
        [DataRow(-1, false)]
        public void IsPalindromeTest(int word, bool expectedBool)
        {
            //PREPARE
            ConsoleAppPalindrome consoleAppPalindrome = new ConsoleAppPalindrome();

            //ACT
            bool actualBool = ConsoleAppPalindrome.IsPalindrome(word);

            //ASSERT
            Assert.AreEqual(expectedBool, actualBool, word.ToString());
        }

        [TestMethod]
        [DataRow(22.22, true)]
        [DataRow(23.22, false)]
        [DataRow(23.32, true)]
        public void IsPalindromeTest(double word, bool expectedBool)
        {
            //PREPARE
            ConsoleAppPalindrome consoleAppPalindrome = new ConsoleAppPalindrome();

            //ACT
            bool actualBool = ConsoleAppPalindrome.IsPalindrome(word);

            //ASSERT
            Assert.AreEqual(expectedBool, actualBool, word.ToString());
        }
    }
}
