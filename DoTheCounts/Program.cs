// ========== Created by Thomas Beck @ 2017 ========== \\

using System;

namespace DoTheCounts
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Convert to be called below
            Converter converter = new Converter();

            // Create a loop = true for infinate loops
            while (true)
            {
                // Take the user input ReadLine set = input
                string input = Console.ReadLine();

                // Set output = 0
                int number = 0;

                // Try to parse the int that was entered, grab input from ReadLine, output number
                if (!int.TryParse(input, out number))

                    // Catch anything that couldn't be parsed
                    Console.WriteLine("Please input any number here!");
                else

                    // If parsed, create a new stringbuilder stating what the user input and what the converter output
                    Console.WriteLine($"you entered:{input} ===> it was {converter.Translate(number)}");
            }
        }
    }
}
