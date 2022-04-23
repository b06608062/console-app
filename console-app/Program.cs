using System;

namespace console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My First C# App";
            Console.Beep(300, 500);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string isContinued;
            double kg;
            double lb;
            double tg;
            do
            {
                Console.Write("Choose your input unit (1) kg (2) lb (3) tg:");
                string transformType = Console.ReadLine();
                Console.Write("Your weight = ");
                string originalWeight = Console.ReadLine();
                double originalValue = Convert.ToDouble(originalWeight);
                if (transformType == "1")
                {
                    kg = originalValue;
                    lb = originalValue * 2.20462;
                    tg = originalValue * 1.66667;
                }
                else if (transformType == "2")
                {
                    kg = originalValue * 0.45359;
                    lb = originalValue;
                    tg = originalValue * 0.75599;
                }
                else
                {
                    kg = originalValue * 0.6;
                    lb = originalValue * 1.32277;
                    tg = originalValue;
                }

                Console.WriteLine($"{kg} kg = {lb} lb = {tg} tg");
                Console.Write("Continue?(y/n):");
                isContinued = Console.ReadLine();
            } while (isContinued == "y");

            Console.ReadKey();
        }
    }
}
