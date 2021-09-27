using System;
using System.Collections.Generic;
using System.Text;

namespace ciphers_cs
{
    public class AtbashCipher
    {
        internal readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        internal readonly string tebahpla = "zyxwvutsrqpomnlkjihgfedcba";

        public string Encrypt( string text )
        {
            text = text.ToLower();
            text = text.Replace(" ", string.Empty);
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += tebahpla[alphabet.IndexOf(text[i])];
            }
            return result;
        }

        public string Decrypt( string text )
        {
            text = text.ToLower();
            text = text.Replace(" ", string.Empty);
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += alphabet[tebahpla.IndexOf(text[i])];
            }
            return result;
        }
    }
}
