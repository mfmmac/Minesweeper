using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    static class MinesweeperValidator
    {
        public static string ValidateContinue()
        {
            List<string> validInput = new List<string>()
            {
                "YES",
                "Y",
                "NO",
                "N"
            };

            Console.WriteLine("Would you like to play another game? (Yes/No)");
            string userInput = Console.ReadLine().ToUpper();

            while (!validInput.Contains(userInput))
            {
                Console.WriteLine("Invalid entry. Please try again");
                userInput = Console.ReadLine().ToUpper();
            }

            return userInput;
        }
    }
}
