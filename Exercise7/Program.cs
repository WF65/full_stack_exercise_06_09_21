using System;

namespace Exercise7
{
    class Program
    {
        static public void Main(string[] args)
        {
            int balance = 1000;
            balance = DisplayTransaction(balance);
                        
        }

        static int DisplayTransaction(int balance)
        {
            Console.WriteLine("Enter Your Pin number");
            string pin = "123";
            string inputPin = Console.ReadLine();
            if (inputPin == pin)
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.Write("\n");
                Console.WriteLine("1. Check Balance");
                Console.Write("\n");
                Console.WriteLine("2. Withdraw Cash");
                Console.Write("\n");
                Console.WriteLine("3. Deposit Cash");
                Console.Write("\n");
                Console.WriteLine("4. Quit");
                Console.Write("\n");
                Console.WriteLine("*********************************************");
                bool ifQuit = false;
                while (!ifQuit)
                {
                    Console.WriteLine("Enter your choice:");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($" YOU’RE BALANCE IN Rs: {balance}");
                            break;

                        case "2":
                            Console.WriteLine("Enter withdraw amount:");
                            int withdraw = Convert.ToInt32(Console.ReadLine());
                            balance = balance - withdraw;
                            Console.WriteLine($" YOU’RE BALANCE IN Rs: {balance}");
                            break;
                        case "3":
                            Console.WriteLine("Enter deposit amount:");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            balance = balance + deposit;
                            Console.WriteLine($" YOU’RE BALANCE IN Rs: {balance}");
                            break;
                        case "4":
                            ifQuit = true;
                            break;
                        default:
                            Console.WriteLine("Choice not available, please retry.");
                            break;
                    }
                    
                }
                return balance;
            }
            else
            {
                Console.WriteLine("Wrong pin, please retry.");
                return balance;
            }
        }

    }
}
