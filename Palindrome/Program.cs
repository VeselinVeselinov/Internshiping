using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input=input.ToLower();
            input=input.Replace(" ","");
            if (CheckForPalindrome(input)==true)
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
                if (SwitchLetterAndCheckForAPalindrome(input)==true)
                {
                    Console.WriteLine("But a palindrome can be created with these letters");
                }
                else
                {
                    Console.WriteLine("And no palindrome can be created with these letters");
                }
            }
        }

        static bool SwitchLetterAndCheckForAPalindrome(string input)
        {
            string temp = "";
            bool isPossible = false;
            List<string> inputByLetter = BreakWordIntoList(input);
            List<string> allPossiblePalindromes = new List<string>();
            for (int i = 0; i < inputByLetter.Count; i++)
            {
                for (int t = 0; t < inputByLetter.Count; t++)
                {
                    temp = inputByLetter[i];
                    inputByLetter[i] = inputByLetter[t];
                    inputByLetter[t] = temp;
                    if (CheckForPalindrome(FromListToString(inputByLetter))==true)
                    {
                        isPossible = true;
                    }
                }
            }
            return isPossible;
        }

        static bool CheckForPalindrome(string input)
        {
            List<string> inputByLetters = new List<string>();
            List<string> reversedInput = new List<string>();
            foreach (char item in input)
            {
                inputByLetters.Add(item.ToString());
                reversedInput.Add(item.ToString());
            }
            reversedInput.Reverse();
            int sameLettersCount = 0;
            for (int i = 0; i < inputByLetters.Count; i++)
            {
                if (inputByLetters[i] == reversedInput[i])
                {
                    sameLettersCount++;
                }
            }
            if (sameLettersCount == inputByLetters.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static List<string> BreakWordIntoList(string input)
        {
            List<string> inputByLetters = new List<string>();
            foreach (char item in input)
            {
                inputByLetters.Add(item.ToString());
            }
            return inputByLetters;
        }

        static string FromListToString(List<string> inputByLetters)
        {
            string finalWord = "";
            foreach (string item in inputByLetters)
            {
                finalWord += item;
            }
            return finalWord;
        }
    }
}
