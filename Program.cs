using System;
using System.Drawing;

namespace GroupDMinefieldMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // userContinue set to true
            bool userContinue = true;
            // welcoming user to minesweeper
            Console.WriteLine("Welcome to Group D's Minesweeper game!");
            //code executed while user continue is true
            while (userContinue)
            {
                //creating the minesweeper game
                Minesweeper minesweeper = new Minesweeper();
                //while minesweeper is not game over and game won
                while (!minesweeper.GameOver && !minesweeper.GameWon)
                {
                    minesweeper.GetUserSelection();
                }

                if (minesweeper.GameWon)
                {
                    Display.GameEndScreen(true);
                }
                else Display.GameEndScreen(false);

                string userInput = MinesweeperValidator.ValidateContinue();

                if (userInput.Equals("NO") || userInput.Equals("N"))
                    userContinue = false;
            }
        }
    }
}
