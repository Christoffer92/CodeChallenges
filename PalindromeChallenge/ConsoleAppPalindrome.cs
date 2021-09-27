using System;

/* 
// ----------------------------
// --- Palindrome Challenge ---
// ----------------------------

- Goal
Create a Console app that can identify if a word is a palindrome (the same forward and backwards like
racecar). Create an overload method to check an int to see if it is a palindrome.

- Bonus
Ignore spacing, casing, and special characters when identifying palindromes. For instance, “stack cats” is a
palindrome.
Also create an overload method to handle doubles.
Implement a extension method for type String that handles the following “Ignore spacing, casing, and
special characters when identifying palindromes”

*/

namespace PalindromeChallenge { 
    public class ConsoleAppPalindrome {
        static void Main(string[] args) {
            while (true) {
                string word = Console.ReadLine();
                bool res = IsPalindrome(word);
                if (res == false) {
                    Console.WriteLine(word + " is not a Palindrome");
                } else {
                    Console.WriteLine(word + " is a Palindrome");
                }
            }
        }

        static public bool IsPalindrome(string word) {
            bool isPalindrome = true;
            word = word.RemoveSpecialChareters();
            int wordLength = word.Length;

            if (wordLength % 2 != 0) {
                word = word.RemoveMiddleCharacter();
                wordLength = word.Length;
            }
            int wordHalfLength = wordLength / 2;

            for (int i = 0; i < wordHalfLength; i++) {
                char character1 = word[i];
                char character2 = word[wordLength - 1 - i];
                if (character1 != character2) {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
        }

        static public bool IsPalindrome(int wholeNumber) {
            return IsPalindrome(wholeNumber.ToString());
        }

        static public bool IsPalindrome(double doubleNumber) {
            return IsPalindrome(doubleNumber.ToString());
        }

    }
    
}
