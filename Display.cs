using System;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public static class Display
    {
        public static void DisplayBoard(GameBoard gameBoard)
        {
            DisplayScore(gameBoard.RemainingCells);
            DisplayColumns(gameBoard.BoardColumns);

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

        private static void DisplayColumns(int columns)
        {
            Console.WriteLine();
            Console.Write("  ");
            for (int i = 0; i < columns; i++)
            {
                Console.Write($"{i:00} ");
            }
        }

        private static void DisplayScore(int score)
        {
            Console.WriteLine("\n -------------------------------");
            Console.WriteLine($"|\tRemaining cells: {score}\t|");
            Console.WriteLine(" -------------------------------");
        }

        public static void GameEndScreen(bool winOrLose)
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

            Console.WriteLine("\n\n----------------------------------------------");
            Console.WriteLine(gameEndMessage);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
