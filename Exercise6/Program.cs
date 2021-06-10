using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDiamond();
        }

        static void PrintDiamond()
        {
            Console.WriteLine("Please input No. of rows:");
            int noOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The diamond:");
            int width = 2*noOfRows - 1;
            //Console.WriteLine($"{width}");
            for (int i = 1; i <= noOfRows; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if(j > (noOfRows - i) && j < (noOfRows + i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }
            for (int i = (noOfRows -1); i >= 1; i--)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (j > (noOfRows - i) && j < (noOfRows + i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
