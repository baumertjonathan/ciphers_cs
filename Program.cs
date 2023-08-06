using System;
using ciphers_cs;

namespace ciphers_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Caesar Cipher=====");
            CaesarCipher CaesarCipherObj = new CaesarCipher();
            string result = CaesarCipherObj.Encrypt("Hello There", 3);
            Console.WriteLine($"encrypted: {result}");
            string decrypted = CaesarCipherObj.Decrypt(result, 3);
            Console.WriteLine($"decrypted: {decrypted}");

            Console.WriteLine("=====Baconian Cipher=====");
            BaconianCipher BaconianCipherObjOld = new BaconianCipher(false);
            BaconianCipher BaconianCipherObjNew = new BaconianCipher(true);
            string newEncrypted = BaconianCipherObjNew.Encrypt("Hello There");
            string oldEncrypted = BaconianCipherObjOld.Encrypt("Hello There");
            Console.WriteLine($"Modern Encrypted: {newEncrypted}");
            Console.WriteLine($"Traditional Encrypted: {oldEncrypted}");
            Console.WriteLine($"Modern Decrypted: {BaconianCipherObjNew.Decrypt(newEncrypted)}");
            Console.WriteLine($"Traditional Decrypted: {BaconianCipherObjOld.Decrypt(oldEncrypted)}");

            Console.WriteLine("=====Atbash Cipher=====");
            AtbashCipher AtbashCipherObj = new AtbashCipher();
            string encrypted = AtbashCipherObj.Encrypt("Hello There");
            Console.WriteLine($"encrypted: {encrypted}");
            Console.WriteLine($"decrypted: {AtbashCipherObj.Decrypt(encrypted)}");

            Console.WriteLine("=====Vigenere Cipher=====");
            VigenereCipher VigenereCipherObj = new VigenereCipher();
            encrypted = VigenereCipherObj.Encrypt("Hello There", "secret");
            Console.WriteLine($"encrypted: {encrypted}");
            Console.WriteLine($"decrypted: {VigenereCipherObj.Decrypt(encrypted, "secret")}");

            Console.WriteLine("=====Affine Cipher=====");
            AffineCipher AffineCipherObj = new AffineCipher();
            encrypted = AffineCipherObj.Encrypt("Hello There", 5, 9);
            Console.WriteLine($"encrypted: {encrypted}");
            Console.WriteLine($"decrypted: {AffineCipherObj.Decrypt(encrypted, 5, 9)}");

            Console.WriteLine("=====Substitution Cipher=====");
            SubstitutionCipher SubstitutionCipherObj = new SubstitutionCipher();
            encrypted = SubstitutionCipherObj.Encrypt("Hello There", "qwertyuiopasdfghjklzxcvbnm");
            Console.WriteLine($"encrypted: {encrypted}");
            Console.WriteLine($"decrypted: {SubstitutionCipherObj.Decrypt(encrypted, "qwertyuiopasdfghjklzxcvbnm")}");

        }
    }
}
