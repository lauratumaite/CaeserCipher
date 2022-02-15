using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher
{
    public static class Cipher
    {
        static void Main(string[] args)
        {
            bool isNumeric = false;
            int shift = 0;

            //we should check if the shift (key) is numeric, otherwise we will get an error, also it should be a digit
            while (shift < 0 || !isNumeric)
            {
                Console.WriteLine("Please type in a digit equal or bigger than zero (it will be used as a key / shift): ");
                isNumeric = int.TryParse(Console.ReadLine(), out shift);
                Console.WriteLine("\n");
            }


            Console.WriteLine("Type in a message you would like to encrypt: ");
            string inputText = Console.ReadLine();
            Console.WriteLine("\n");

            string encryptedText = Encipher(inputText, shift);
            Console.WriteLine("Encrypted text with Caeser Cipher: " + encryptedText + "\n");

            string decryptedText = Decipher(encryptedText, shift);
            Console.WriteLine("Decrypted Data with Caeser Cipher: " + decryptedText + "\n");

            Console.ReadKey();
        }

        public static char inputCipher(char ch, int shift)
        {
            char i;

            if (!char.IsLetter(ch))
                return ch;
            //we have to check if the letter is upper or lower, that will change the calculation 
            if (char.IsUpper(ch))
                i = 'A';

            else
                i = 'a';

            //we have to convert each char, the mathematical formula is (letter + shift) mod 26, but we do have to ignore is the letter upper or lower thats why we have +-i
            return (char)((((ch + shift) - i) % 26) + i);
        }


        public static string Encipher(string input, int shift)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += inputCipher(ch, shift);

            return output;
        }

        public static string Decipher(string input, int shift)
        {
            return Encipher(input, 26 - shift);
        }
    }
}
