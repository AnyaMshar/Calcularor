using System;

namespace Calculator_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Enter first number");

            string num1Str = Console.ReadLine();
            bool parseRes1 = Int32.TryParse(num1Str, out int num1);
        }
    }
}
