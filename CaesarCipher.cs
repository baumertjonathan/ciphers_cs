using System;

namespace ciphers_cs
{
   public class CaesarCipher
   {
        private readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string Encrypt(string text, int key)
        {
            string Result = "";
            text = text.Replace(" ", string.Empty);
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                int index = alphabet.IndexOf(text[i]) + key;
                Result += alphabet[index >= 26 ? index - 26 : index];
            }
            return Result;
        }
        public string Decrypt(string text, int key)
        {
            string Result = "";
            text = text.Replace(" ", string.Empty);
            for (int i = 0; i < text.Length; i++)
            {
                int index = alphabet.IndexOf(text[i]) - key;
                Result += alphabet[index < 0 ? index + 26 : index];
            }
            return Result;
        }
   }
}
