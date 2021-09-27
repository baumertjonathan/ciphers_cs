using System;
using System.Collections.Generic;
using System.Text;

namespace ciphers_cs
{
    class AffineCipher
    {
        internal readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string Encrypt(string text, int a, int b)
        {
            string result = "";
            text = text.ToLower();
            text = text.Replace(" ", "");
            if (!Validate(a, b))
            {
                throw new ArgumentException("a must be coprime with 26 and both a and b must be between 1 and 26");
            }

            for (int i = 0; i < text.Length; i++)
            {
                result += alphabet[((a * alphabet.IndexOf(text[i]) + b) % 26)];
            }
            return result;
        }

        public string Decrypt(string text, int a, int b)
        {
            string result = "";
            text = text.ToLower();
            text = text.Replace(" ", "");

            int a_inv = 0;

            for (int i = 0; i < 26; i++)
            {
                int f = (a * i) % 26;
                if (f == 1)
                {
                    a_inv = i;
                }
            }

            for(int i = 0; i < text.Length; i++)
            {
                int p = a_inv * (alphabet.IndexOf(text[i]) - b) % 26;
                result += alphabet[p > 0 ? p : 26+p]; // wraparound index
            }
            return result;
        }

        internal bool Validate(int a, int b)
        {
            if (a < 1 || a > 26) 
            {
                return false;
            }
            if (b < 1 || b > 26) 
            {
                return false;
            }
            int[] possibleAValues = new int[] { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };
            if (Array.Exists(possibleAValues, element => element == a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
