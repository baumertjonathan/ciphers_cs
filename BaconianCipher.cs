using System;
using System.Collections.Generic;
using System.Text;

namespace ciphers_cs
{
    public class BaconianCipher
    {
        public BaconianCipher(bool ismodern)
        {
            modern = ismodern;
        }

        private bool modern;
        internal readonly Dictionary<char, string> Baconian26E = new Dictionary<char, string>()
        {
            { 'a', "aaaaa" },
            { 'b', "aaaab" },
            { 'c', "aaaba" },
            { 'd', "aaabb" },
            { 'e', "aabaa" },
            { 'f', "aabab" },
            { 'g', "aabba" },
            { 'h', "aabbb" },
            { 'i', "abaaa" },
            { 'j', "abaab" },
            { 'k', "ababa" },
            { 'l', "ababb" },
            { 'm', "abbaa" },
            { 'n', "abbab" },
            { 'o', "abbba" },
            { 'p', "abbbb" },
            { 'q', "baaaa" },
            { 'r', "baaab" },
            { 's', "baaba" },
            { 't', "baabb" },
            { 'u', "babaa" },
            { 'v', "babab" },
            { 'w', "babba" },
            { 'x', "babbb" },
            { 'y', "bbaaa" },
            { 'z', "bbaab" },
            { 'A', "aaaaa" },
            { 'B', "aaaab" },
            { 'C', "aaaba" },
            { 'D', "aaabb" },
            { 'E', "aabaa" },
            { 'F', "aabab" },
            { 'G', "aabba" },
            { 'H', "aabbb" },
            { 'I', "abaaa" },
            { 'J', "abaab" },
            { 'K', "ababa" },
            { 'L', "ababb" },
            { 'M', "abbaa" },
            { 'N', "abbab" },
            { 'O', "abbba" },
            { 'P', "abbbb" },
            { 'Q', "baaaa" },
            { 'R', "baaab" },
            { 'S', "baaba" },
            { 'T', "baabb" },
            { 'U', "babaa" },
            { 'V', "babab" },
            { 'W', "babba" },
            { 'X', "babbb" },
            { 'Y', "bbaaa" },
            { 'Z', "bbaab" },
        };

        internal readonly Dictionary<char, string> Baconian24E = new Dictionary<char, string>()
        {
            { 'a', "aaaaa" },
            { 'b', "aaaab" },
            { 'c', "aaaba" },
            { 'd', "aaabb" },
            { 'e', "aabaa" },
            { 'f', "aabab" },
            { 'g', "aabba" },
            { 'h', "aabbb" },
            { 'i', "abaaa" },
            { 'j', "abaaa" },
            { 'k', "abaab" },
            { 'l', "ababa" },
            { 'm', "ababb" },
            { 'n', "abbaa" },
            { 'o', "abbab" },
            { 'p', "abbba" },
            { 'q', "abbbb" },
            { 'r', "baaaa" },
            { 's', "baaab" },
            { 't', "baaba" },
            { 'u', "baabb" },
            { 'v', "baabb" },
            { 'w', "babaa" },
            { 'x', "babab" },
            { 'y', "babba" },
            { 'z', "babbb" },
            { 'A', "aaaaa" },
            { 'B', "aaaab" },
            { 'C', "aaaba" },
            { 'D', "aaabb" },
            { 'E', "aabaa" },
            { 'F', "aabab" },
            { 'G', "aabba" },
            { 'H', "aabbb" },
            { 'I', "abaaa" },
            { 'J', "abaaa" },
            { 'K', "abaab" },
            { 'L', "ababa" },
            { 'M', "ababb" },
            { 'N', "abbaa" },
            { 'O', "abbab" },
            { 'P', "abbba" },
            { 'Q', "abbbb" },
            { 'R', "baaaa" },
            { 'S', "baaab" },
            { 'T', "baaba" },
            { 'U', "baabb" },
            { 'V', "baabb" },
            { 'W', "babaa" },
            { 'X', "babab" },
            { 'Y', "babba" },
            { 'Z', "babbb" },
        };

        internal readonly Dictionary<string, char> Baconian26D = new Dictionary<string, char>()
        {
            { "aaaaa", 'a' },
            { "aaaab", 'b' },
            { "aaaba", 'c' },
            { "aaabb", 'd' },
            { "aabaa", 'e' },
            { "aabab", 'f' },
            { "aabba", 'g' },
            { "aabbb", 'h' },
            { "abaaa", 'i' },
            { "abaab", 'j' },
            { "ababa", 'k' },
            { "ababb", 'l' },
            { "abbaa", 'm' },
            { "abbab", 'n' },
            { "abbba", 'o' },
            { "abbbb", 'p' },
            { "baaaa", 'q' },
            { "baaab", 'r' },
            { "baaba", 's' },
            { "baabb", 't' },
            { "babaa", 'u' },
            { "babab", 'v' },
            { "babba", 'w' },
            { "babbb", 'x' },
            { "bbaaa", 'y' },
            { "bbaab", 'z' },
        };

        internal readonly Dictionary<string, char> Baconian24D = new Dictionary<string, char>()
        {
            { "aaaaa", 'a' },
            { "aaaab", 'b' },
            { "aaaba", 'c' },
            { "aaabb", 'd' },
            { "aabaa", 'e' },
            { "aabab", 'f' },
            { "aabba", 'g' },
            { "aabbb", 'h' },
            { "abaaa", 'i' },
            { "abaab", 'k' },
            { "ababa", 'l' },
            { "ababb", 'm' },
            { "abbaa", 'n' },
            { "abbab", 'o' },
            { "abbba", 'p' },
            { "abbbb", 'q' },
            { "baaaa", 'r' },
            { "baaab", 's' },
            { "baaba", 't' },
            { "baabb", 'u' },
            { "babaa", 'w' },
            { "babab", 'x' },
            { "babba", 'y' },
            { "babbb", 'z' },
        };

        public string Encrypt(string text)
        {
            text = text.Replace(" ", string.Empty);
            string result = "";
            for (int i = 0; i < text.Length; i++) 
            {
                if (modern)
                {
                    result += Baconian26E[text[i]];
                }
                else
                {
                    result += Baconian24E[text[i]];
                }
            }
            return result;
        }
        public string Decrypt(string text)
        {
            text = text.Replace(" ", string.Empty);
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                string section = string.Empty;
                int counter = 0;
                while (counter < 5) 
                {
                    section += text[i];
                    counter++;
                    i++;
                }
                i--;
                if (modern)
                {
                    result += Baconian26D[section];
                }
                else
                {
                    result += Baconian24D[section];
                }
            }
            return result;
        }

    }
}
