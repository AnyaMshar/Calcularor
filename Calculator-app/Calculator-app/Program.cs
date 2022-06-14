using System;
using System.Collections.Generic;

namespace Calculator_app
{
    class Program
    {
        public static Dictionary<string, string> Users = new Dictionary<string, string>
        {
            {"Ilya", "12345"},
            {"Anya", "987654321"}
        };

        static void Main(string[] args)
        {
            Hello();

            bool checkUser = TryLogin(out string userName);

            while (checkUser)
            {
                Menu();

                var res1 = EnterNumber();

                if (res1 != -1)
                {
                    Console.Write("Enter number 1: ");

                    var num1 = EnterNumber();

                    if (num1 != -1)
                    {
                        Console.Write("Enter number 2: ");

                        var num2 = EnterNumber();

                        if (num2 != -1)
                        {
                            switch (res1)
                            {
                                case 1:
                                    Sum(num1, num2);
                                    break;
                                case 2:
                                    Dif(num1, num2);
                                    break;
                                case 3:
                                    Mult(num1, num2);
                                    break;
                                case 4:
                                    if (num2 == 0)
                                    {
                                        DivByZero();
                                        break;
                                    }
                                    else
                                    {
                                        Div(num1, num2);
                                        break;
                                    }
                                case 5:
                                    if (num2 == 0)
                                    {
                                        DivByZero();
                                        break;
                                    }
                                    else
                                    {
                                        Rem(num1, num2);
                                        break;
                                    }
                                default:
                                    Kiss();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Mistake("Error. enter a number.");
                    }
                }
                else
                {
                    Mistake("Error. enter a number.");
                }

                int counter = 0;

                while (true)
                {
                    Next();

                    var con1 = EnterNumber();

                    if (con1 == 0)
                    {
                        GoodBye(userName);
                    }
                    else if (con1 == 1)
                    {
                        break;
                    }
                    else
                    {
                        counter++;

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"You have {3 - counter} attempts.");
                        Console.WriteLine();
                        Console.ResetColor();

                        if (counter == 3)
                        {
                            Mistake("You used 3 attempts for entry.");
                            GoodBye(userName);
                        }
                    }
                }
            }
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select arithmetic operation.");
            Console.WriteLine("Press 1 - Sum");
            Console.WriteLine("Press 2 - Dif");
            Console.WriteLine("Press 3 - Mult");
            Console.WriteLine("Press 4 - Dev");
            Console.WriteLine("Press 5 - Rem");
            Console.WriteLine("Press 6 - Kiss");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Next()
        {
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("If YES - press 1");
            Console.WriteLine("if do you want to exit - press 0");
            Console.WriteLine();
        }

        public static void Sum(decimal a, decimal b)
        {
            decimal result = a + b;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Sum = {result}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Dif(decimal a, decimal b)
        {
            decimal result = a - b;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Difference = {result}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Mult(decimal a, decimal b)
        {
            decimal result = a * b;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Product = {result}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Div(decimal a, decimal b)
        {
            if (b == 0)
            {
                DivByZero();
            }
            else
            {
                decimal result = a / b;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Quotient = {result}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static void Rem(decimal a, decimal b)
        {
            if (b == 0)
            {
                DivByZero();
            }
            else
            {
                decimal result = a % b;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Remainder of division = {result}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static void Kiss()
        {
            Console.WriteLine("Kiss, kiss");
        }

        public static void Mistake(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void DivByZero()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error. Dividing by zero is disallowed.");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static int EnterNumber()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string enter = Console.ReadLine();
            Console.WriteLine();
            Console.ResetColor();

            bool con = int.TryParse(enter, out int result);

            if (con)
            {
                return result;
            }
            else
            {
                Mistake("Error. You have to enter a number.");

                return -1;
            }
        }

        public static void Hello()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hello. ");
            Console.ResetColor();
        }

        public static bool TryLogin(out string name)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter your name: ");
                Console.ResetColor();

                name = Console.ReadLine();
                Console.WriteLine();

                var checkName = Users.TryGetValue(name, out string pass);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}, please, write your password: ");
                Console.ResetColor();

                string password = Console.ReadLine();
                Console.WriteLine();

                if (checkName && (password == pass))
                {
                    Console.WriteLine($"Hello, {name}. Welcome to the Calculator.\n");

                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered the wrong name or password. Try again.\n");
                    Console.ResetColor();
                }
            }

            return true;
        }
        
        public static void GoodBye(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Good bye, {name}.");
            Console.WriteLine();
            Console.ResetColor();

            Environment.Exit(0);
        }
    }
}
