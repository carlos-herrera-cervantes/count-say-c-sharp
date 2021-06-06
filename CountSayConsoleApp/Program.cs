using System;
using CountSayDomain.Models;

namespace CountSayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string message = "Enter a number less or equal than 30: ";
            
            string number = "";
            int integer;

            while (!int.TryParse(number, out integer))
            {
                number = PrintMessage(message);
            }

            int parsed = int.Parse(number);

            while (parsed > 30)
            {
                number = PrintMessage(message);
            }

            string result = SuperInteger.CountAndSay(parsed);

            Console.WriteLine($"Equivalent count and say is: {result}");
        }

        private static string PrintMessage(string message)
        {
            Console.Write(message);
            string number = Console.ReadLine();
            Console.WriteLine();

            return number;
        }
    }
}
