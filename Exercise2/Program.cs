using System;

namespace Exercise2
{
    class Program
    {
        public class Arithmetic
        {
            int a = 30;
            int b = 20;
            public void Addition()
            {
                Console.WriteLine($"The addition result is {a + b}");
            }

            public void Substraction()
            {
                Console.WriteLine($"The substraction result is {a - b}");
            }

            public void Multiplication()
            {
                Console.WriteLine($"The multiplication result is {a * b}");
            }

            public void Division()
            {
                Console.WriteLine($"The division result is {a / b}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Select arithmetic operation(addition/substraction/multiplication/division)");
            string choice = Console.ReadLine();
            Arithmetic arithmetic = new Arithmetic();
            switch (choice)
            {
                case "addition":
                    arithmetic.Addition();
                    break;
                case "substraction":
                    arithmetic.Substraction();
                    break;
                case "multiplication":
                    arithmetic.Multiplication();
                    break;
                case "division":
                    arithmetic.Division();
                    break;

                default:
                    break;
            }
        }
    }
}
