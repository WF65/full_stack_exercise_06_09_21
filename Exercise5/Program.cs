using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBinaryTriangle();
        }

        static void PrintBinaryTriangle()
        {
            Console.WriteLine("Please input No. of rows:");
            int noOfRows = Convert.ToInt32(Console.ReadLine());
            int lastInt = 0;
            Console.WriteLine("The binary triangle:");
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
