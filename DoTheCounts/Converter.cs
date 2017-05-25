// ========== Created by Thomas Beck @ 2017 ========== \\

namespace DoTheCounts
{
    public class Converter
    {
        // Create a public string meathod (I called it Translate) that takes an int named input
        public string Translate(int input)
        {
                // Set myAnswer = null
                string myAnswer = "";
                
                // Handle everything else higher than 1,000,000
                if (input > 1000000) return "The number you entered was way too big! Enter something else...";
          
                // For anything above 1000, returns M. Takes the input - 1000.
                if (input >= 1000) return "M" + Translate(input - 1000);

                // For anything above 900, returns CM. Takes the input - 900.
                if (input >= 900) return "CM" + Translate(input - 900);

                // For anything above 500, returns D. Takes the input - 500.
                if (input >= 500) return "D" + Translate(input - 500);

                // For anything above 400, returns CD. Takes the input - 400.
                if (input >= 400) return "CD" + Translate(input - 400);

                // For anything above 100, returns C. Takes the input - 100. 
                if (input >= 100) return "C" + Translate(input - 100);

                // For anything above 90, returns XC. Takes the input - 90
                if (input >= 90) return "XC" + Translate(input - 90);

                // For anything above 50, return L. Takes the input - 50
                if (input >= 50) return "L" + Translate(input - 50);

                // For anything above 40, return XL. Take the input - 40
                if (input >= 40) return "XL" + Translate(input - 40);

                // For anything above 10, return XL. Take the input - 10
                if (input >= 10) return "X" + Translate(input - 10);

                // For anything above 9, return XL. Take the input - 9
                if (input >= 9) return "IX" + Translate(input - 9);

                // For anything above 5, return XL. Take the input - 5
                if (input >= 5) return "V" + Translate(input - 5);

                // For anything above 4, return XL. Take the input - 4
                if (input >= 4) return "IV" + Translate(input - 4);

                // For anything above 1, return XL. Take the input - 1
                if (input >= 1)
                {
                    // Loop I for each time between 1 - 3 (index < input)
                    for (int index = 1; index <= input; index++)
                    {
                        // For anything below 3, return I until index > input
                        myAnswer += "I";
                    }
                }
            // Return myAnswer
            return myAnswer;
            }
        }
    }