using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public class Display
    {
        public void DisplayBoard(GameBoard gameBoard)
        {
            for (int i = 0; i < gameBoard.BoardRows; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < gameBoard.BoardColumns; j++)
                {
                    if (gameBoard.Board[i, j].Revealed)
                    {
                        Console.Write(gameBoard.Board[i, j].CellValue);
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
        }
    }
}
