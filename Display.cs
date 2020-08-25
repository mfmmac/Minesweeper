using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public static class Display
    {
        public static void DisplayBoard(GameBoard gameBoard)
        {
            Console.WriteLine();
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

                StringBuilder cellOutput = new StringBuilder("");

                for (int j = 0; j < gameBoard.BoardColumns; j++)
                {
                    cellOutput.Clear();

                    if (gameBoard.Board[i, j].Revealed)
                    {
                        GameValues cellValue = gameBoard.Board[i, j].CellValue;
                        

                        switch (cellValue)
                        {
                            case GameValues.Empty:
                                cellOutput.Append("   ");
                                break;
                            case GameValues.Mine:
                                cellOutput.Append(" M ");
                                break;
                            default:
                                cellOutput.Append($" {(int)cellValue} ");                                
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

        public static void GameEndScreen(Boolean winOrLose)
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
