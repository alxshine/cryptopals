using System;

namespace CryptoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            var target = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";
            var converted = Utility.ByteArrayFromHexString(input);
            var convertedString = Utility.HexStringFromBinaryArray(converted);
            var correct = input.CompareTo(convertedString) == 0;

            Console.WriteLine("input: {0}", input);
            Console.WriteLine("converted: {0:x}", convertedString);
            Console.WriteLine("Correct: {0}", correct);
            Console.ReadLine();
        }
    }
}
