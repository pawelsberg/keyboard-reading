using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawelsberg.KeyboardReading
{
    class Word
    {
        static Random rnd = new Random();
        public string Text { get; set; }
        public int KeyDelay { get; set; }
        public static Word GenerateRandomWord(int len, int keydelay, bool letters, bool numbers, bool shift)
        {
            Word ret = new Word();
            char[] chartab = GetCharTab(letters, numbers, shift);
            ret.Text = GenerateRandomString(len, chartab, rnd);
            ret.KeyDelay = keydelay;
            return ret;
        }
        private static char[] GetNumbersCharTab()
        {
            return new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }
        private static char[] GetShiftedNumbersCharTab()
        {
            return new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
        }
        private static char[] GetLettersCharTab()
        {
            char[] ret = new char['z' - 'a' + 1];
            for (char c = 'a'; c <= 'z'; c++)
                ret[c - 'a'] = c;
            return ret;
        }
        private static char[] GetShiftedLettersCharTab()
        {
            char[] ret = new char['Z' - 'A' + 1];
            for (char c = 'A'; c <= 'Z'; c++)
                ret[c - 'A'] = c;
            return ret;
        }

        private static char[] GetCharTab(bool letters, bool numbers, bool shift)
        {
            List<char> chars = new List<char>();
            if (letters)
            {
                chars.AddRange(GetLettersCharTab()); ;
                if (shift)
                    chars.AddRange(GetShiftedLettersCharTab()); ;
            }
            if (numbers)
            {
                chars.AddRange(GetNumbersCharTab());
                if (shift)
                    chars.AddRange(GetShiftedNumbersCharTab());
            }

            return chars.ToArray();
        }
        private static char GenerateRandomChar(char[] chartab, Random rnd)
        {
            return chartab[rnd.Next(chartab.Length - 1)];
        }
        private static string GenerateRandomString(int len, char[] chartab, Random rnd)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
                sb.Append(GenerateRandomChar(chartab, rnd));
            return sb.ToString();
        }
    }
}
