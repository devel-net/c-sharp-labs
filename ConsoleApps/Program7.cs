using System;

namespace ConsoleApps
{
    public static class Utility
    {
        private static readonly string secretKey;

        static Utility()
        {
            secretKey = GenerateSecretKey();
        }

        private static string GenerateSecretKey()
        {
            return "12345";
        }

        public static string Encrypt(string text)
        {
            return "Encrypted Text";
        }
    }

    class Program
    {
        static void Main()
        {
            string encryptedText = Utility.Encrypt("Секретний текст");
            Console.WriteLine(encryptedText);  //  Encrypted Text

            Console.ReadLine();
        }
    }

}