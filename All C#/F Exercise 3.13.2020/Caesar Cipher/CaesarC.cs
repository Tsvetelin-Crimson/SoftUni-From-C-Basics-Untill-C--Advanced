using System;
using System.Text;

namespace Caesar_Cipher
{
    class CaesarC
    {
        static void Main(string[] args)
        {
            string textToBeEncrypted = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();


            for (int i = 0; i < textToBeEncrypted.Length; i++)
            {
                encryptedText.Append((char)(textToBeEncrypted[i] + 3));
            }

            Console.WriteLine(encryptedText);
        }
    }
}
