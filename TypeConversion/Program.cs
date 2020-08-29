using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)

            // This exercise is strange and isn't making conversions click in my head.
            // Not going to send this to GitHub
        {
            RomanNumeral roman;
            roman = 10;
            BinaryNumeral binary;
            // Perform a conversion from a RomanNumeral to a
            // BinaryNumeral:
            binary = (BinaryNumeral)(int)roman;
            // Performs a conversion from a BinaryNumeral to a RomanNumeral.
            // No cast is required:
            roman = binary;
            Console.WriteLine((int)binary);
            Console.WriteLine(binary);
            Console.ReadKey();

        }
    }
}
