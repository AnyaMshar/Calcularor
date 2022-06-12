using System;

namespace Calculator_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Menu();

            var res1 = EnterNumber();
            
            if (res1 != -1)
            {
                Console.WriteLine("Enter number 1:");

                var num1 = EnterNumber();

                if (num1 != -1)
                {
                    Console.WriteLine("Enter number 2:");

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
                    Mistake();
                }
            }
            else
            {
                Mistake();
            }
        }
        
        public static void Menu()
        {
            Console.WriteLine("Select arithmetic operation.");
            Console.WriteLine("Press 1 - Sum");
            Console.WriteLine("Press 2 - Dif");
            Console.WriteLine("Press 3 - Mult");
            Console.WriteLine("Press 4 - Dev");
            Console.WriteLine("Press 5 - Ost");
            Console.WriteLine("Press 6 - Kiss");
        }
        
        public static void Sum(decimal a, decimal b)
        {
            decimal result = a + b;
            
            Console.WriteLine($"Sum = {result}");
        }
        
        public static void Dif(decimal a, decimal b)
        {
            decimal result = a - b;
            
            Console.WriteLine($"Difference = {result}"); ;
        }
        
        public static void Mult(decimal a, decimal b)
        {
            decimal result = a * b;
            
            Console.WriteLine($"Product = {result}");
        }
        
        public static void Div(decimal a, decimal b)
        {
            decimal result = a / b;
            
            Console.WriteLine($"Quotient = {result}");
        }
        
        public static void Rem(decimal a, decimal b)
        {
            decimal result = a % b;
            
            Console.WriteLine($"Remainder of division = {result}");
        }

        public static void Kiss()
        {
            Console.WriteLine("Kiss, kiss");
        }

        public static void Mistake()
        {
            Console.WriteLine("Error");
        }

        public static void DivByZero()
        {
            Console.WriteLine("Error. Dividing by zero is disallowed.");
        }
        
        public static int EnterNumber()
        {
            string enter = Console.ReadLine();
            bool con = int.TryParse(enter, out int result);
            if (con)
            {
                return result;
            }
            else
            {
                Mistake();
                
                return -1;
            }
        }

        public static void Hello()
        {
            Console.WriteLine("Hello. Write your name.");
            
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome to the Calculator, {name}.");
        }
    }
}
