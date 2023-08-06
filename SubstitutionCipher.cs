using System;

namespace ciphers_cs
{
    class SubstitutionCipher
    {
        internal readonly string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string Encrypt(string text, string key){
            string result = "";
            if(key.Length != 26){
                throw new ArgumentException("key must be exactly 26 characters long");
            }
            // TODO: check that the key has only unique characters
            text = text.ToLower();
            key = key.ToLower();
            for(int i = 0; i < text.Length; i++){
                if(text[i] == ' '){
                    result += " ";
                }
                else{
                    result += key[alphabet.IndexOf(text[i])];
                }
            }
            return result;
        }

        public string Decrypt(string text, string key){
            string result = "";
            if(key.Length != 26){
                throw new ArgumentException("key must be exactly 26 characters long");
            }
            text = text.ToLower();
            key=key.ToLower();
            for(int i = 0; i < text.Length; i++){
                if(text[i] == ' '){
                    result += " ";
                }
                else{
                    result += alphabet[key.IndexOf(text[i])];
                }
            }
            return result;
        }
    }



}