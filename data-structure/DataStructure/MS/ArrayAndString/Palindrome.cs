using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MS
{
    public class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            char[] arr = s.ToCharArray();

            int size = arr.Length;

            for (int i = 0; i < size / 2; i++)
            {
                if (arr[i] != arr[size - i-1])
                {
                    return false;
                }
            }
            
            return true;
        }

        //Leet Code solution
        public bool LC_IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (i < j && !Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while (i < j && !Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                    return false;
            }

            return true;
        }
    }
}
