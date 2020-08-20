using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public class Display
    {
        public void DisplayBoard(GameBoard gameBoard)
        {
            Console.Write("  ");
            for (int i = 0; i < gameBoard.BoardColumns; i++)
            {
                Console.Write($"{i:00} ");
            }

            for (int i = 0; i < gameBoard.BoardRows; i++)
            {
                char label = (char)(i + 65);
                Console.WriteLine();
                Console.Write($"{label}");

                for (int j = 0; j < gameBoard.BoardColumns; j++)
                {
                    if (gameBoard.Board[i, j].Revealed)
                    {
                        GameValues cellValue = gameBoard.Board[i, j].CellValue;
                        String cellOutput;

                        switch (cellValue)
                        {
                            case GameValues.Empty:
                                cellOutput = "   ";
                                break;
                            case GameValues.Mine:
                                cellOutput = " M ";
                                break;
                            default:
                                cellOutput = $" {(int)cellValue} ";
                                break;
                        }
                        Console.Write(cellOutput);
                    }
                    else
                    {
                        Console.Write(" - ");
                    }
                }
            }
        }

        public void GameEndScreen(Boolean winOrLose)
        {
            string gameEndMessage;

            if (winOrLose)
            {
                gameEndMessage = "Congratulations! You've won the game!!!!";
            }
            else
            {
                gameEndMessage = "Try better next time. You've lost the game!!!!";
            }

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine(gameEndMessage);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
