using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChallenge
{
    public static class StringUtils {

        public static string RemoveMiddleCharacter(this string word) {
            int halfLen = word.Length / 2;
            string subString1 = word.Substring(0, halfLen);
            string subString2 = word.Substring(halfLen + 1);
            return subString1 + subString2;
        }

        public static string RemoveSpecialChareters(this string str) {
            string newStr = "";
            for (int i = 0; i < str.Length; i++) {
                if (!IsCharacterSpecial(str[i])) {
                    newStr += str[i];
                }
            }
            return newStr;
        }

        public static bool IsCharacterSpecial(this char c) {
            return (((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) == false);
        }

    }
}
