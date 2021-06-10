using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            FindArmStrong();
        }

        static void FindArmStrong()
        {
            Console.WriteLine("Please input number 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input number 2");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                int temp = y;
                y = x;
                x = temp;
            }

            

            Console.WriteLine("The armstrong number includes:");

            for (int i = x; i < (y + 1); i++)
            {
                int remainder = 0, sum = 0;
                int digitCount = CountDigits(i, 0);
                //Console.WriteLine($"{digitCount}");
                if (digitCount > 1)
                {
                    for (int j = i; j > 0; j = j / 10)
                    {
                        remainder = j % 10;
                        int addition = remainder;
                        for (int k = 1; k < digitCount; k++)
                        {
                            addition = addition * remainder;
                        }

                        sum = sum + addition;
                    }
                    if (i == sum)
                    {
                        Console.WriteLine($"{sum}");
                    }
                }
                else
                {
                    sum = i * i * i;
                    if (sum == i)
                    {
                        Console.WriteLine($"{sum}");
                    }
                }
            }

        }

        static int CountDigits(int n, int digitCount)
        {
            if(n == 0)
            {
                return digitCount;
            }
            return CountDigits(n / 10, ++digitCount);
            
        }
    }
}
