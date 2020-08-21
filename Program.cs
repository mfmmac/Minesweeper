using System;
using System.Drawing;

namespace GroupDMinefieldMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Minesweeper minesweeper = new Minesweeper();

            while(!minesweeper.GameOver)
            {
                minesweeper.GetUserSelection();
            }
        }
    }
}
