using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
        }

        static void ReverseString()
        {
            Console.WriteLine("Plese input the string:");
            string inString = Console.ReadLine();
            char[] charArray = inString.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("The reversed string is");
            Console.WriteLine(new string(charArray));

        }
    }
}
