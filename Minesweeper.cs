using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GroupDMinefieldMidterm
{
    //getting user diffifculty, user input rows and columns
    public class Minesweeper
    {
        //properties
        public bool GameOver { get; set; }
        public bool GameWon { get; set; }
        public GameBoard Game { get; set; }
        //running the game and getting user input
        public Minesweeper()
        {
           //constructor
            GameOver = false;
            GameWon = false;
            Game = new GameBoard(GetUserDifficulty());
            Display.DisplayBoard(Game);
        }
        //getting user input
        public string GetUserDifficulty()
        {
            Console.WriteLine("\nWould you like to play a game?");
            Console.WriteLine("Select your difficulty - 1: Beginner 2: Intermediate 3: Expert");
            string userInput = Console.ReadLine();
            //Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the operation succeeded.
            bool parsed = int.TryParse(userInput, out int userDifficulty);

            while (!parsed || (userDifficulty < 1) || (userDifficulty > 3))
            {
                Console.WriteLine("Invalid entry. Please enter 1, 2, or 3.");
                userInput = Console.ReadLine();
                parsed = int.TryParse(userInput, out userDifficulty);
            }

            switch (userDifficulty)
            {
                case 1:
                    return "Beginner";
                case 2:
                    return "Intermediate";
                case 3:
                    return "Expert";
                default:
                    break;
            }
            return "";
        }
        //getting user selection column and rows
        public void GetUserSelection()
        {
            var columnInput = GetUserColumn();
            var rowInput = GetUserRow();
            Point point = new Point(rowInput, columnInput);
            Game.CheckCell(point);
            if (Game.HitMine)
            {
                GameOver = true;
            }
            else if (Game.RemainingCells <= 0)
            {
                GameWon = true;
            }
            Display.DisplayBoard(Game);
        }
        // getting user selection column
        private int GetUserColumn()
        {
            Console.WriteLine("\nPlease enter column");
            string userInput = Console.ReadLine();

            //Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the operation succeeded.
            bool parsed = int.TryParse(userInput, out int userColumn);

            while (!parsed || userColumn < 0 || userColumn > (Game.BoardColumns - 1))
            {
                Console.WriteLine("\nInvalid entry. Please enter a valid column.");
                userInput = Console.ReadLine();
                parsed = int.TryParse(userInput, out userColumn);
            }
            return userColumn;
        }
        //getting user input row
        private int GetUserRow()
        {
            //convert the value from given string to its equivalent Unicode character
            var upperBound = Game.BoardRows + 64;
            Console.WriteLine("\nPlease enter row");
            string userInput = Console.ReadLine().ToUpper();
            char userRow;

            while ((!Char.TryParse(userInput, out userRow)) || (userRow < 'A') || userRow > (char)upperBound)
            {
                Console.WriteLine("\nInvalid entry. Please enter a valid row");
                userInput = Console.ReadLine().ToUpper();
            }
            //converting the ASCII character (letter) back to a number (integer).
            //This particular statement above says to return in integer form the userRow - 65.  So if it is A it will be 65 (for A) minu 65 = 0, and it will return zero.
            //If it is B, it will be 66 - 65 = 1(B is 66 on the ASCII table)
            return (int)(userRow - 65);
        }
    }
}
