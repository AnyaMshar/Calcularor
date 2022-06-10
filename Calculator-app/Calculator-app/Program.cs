using System;

namespace Calculator_app
{
    class Program
    {
        static void Main(string[] args)
        {
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
                                Dev(num1, num2);
                                break;
                            case 5:
                                Ost(num1, num2);
                                break;
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
            Console.WriteLine("Press 1 - Sum");
            Console.WriteLine("Press 2 - Dif");
            Console.WriteLine("Press 3 - Mult");
            Console.WriteLine("Press 4 - Dev");
            Console.WriteLine("Press 5 - Ost");
            Console.WriteLine("Press 6 - Kiss");
        }
        
        public static void Sum(int a, int b)
        {
            int result = a + b;
            
            Console.WriteLine($"Sum = {result}");
        }
        
        public static void Dif(int a, int b)
        {
            int result = a - b;
            
            Console.WriteLine($"Разность чисел = {result}"); ;
        }
        
        public static void Mult(int a, int b)
        {
            int result = a * b;
            
            Console.WriteLine($"Произведение чисел = {result}");
        }
        
        public static void Dev(int a, int b)
        {
            int result = a / b;
            
            Console.WriteLine($"Частно чисел = {result}");
        }
        
        public static void Ost(int a, int b)
        {
            int result = a % b;
            
            Console.WriteLine($"Остаток от деления = {result}");
        }

        public static void Kiss()
        {
            Console.WriteLine("Kiss, kiss");
        }

        public static void Mistake()
        {
            Console.WriteLine("Error");
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
    }
}
