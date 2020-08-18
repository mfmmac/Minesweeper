using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public class GameBoard
    {
        public int BoardRows { get; set; }
        public int BoardColumns { get; set; }
        public int NumberOfMines { get; set; }
        public GameValues[,] Board { get; set; }



        public GameBoard(string difficulty)
        {
            GenerateBoard(difficulty);
            PlaceMines();
        }
        private void GenerateBoard(string difficulty)
        {
            switch (difficulty)
            {
                case "Beginner":
                    BoardRows = 9;
                    BoardColumns = 9;
                    NumberOfMines = 10;
                    break;
                case "Intermediate":
                    BoardRows = 16;
                    BoardColumns = 16;
                    NumberOfMines = 40;
                    break;
                case "Expert":
                    BoardRows = 16;
                    BoardColumns = 30;
                    NumberOfMines = 99;
                    break;
                default:
                    break;
            }

            Board = new GameValues[BoardRows, BoardColumns];
            for (int i = 0; i < BoardRows; i++)
            {
                for (int j = 0; j < BoardColumns; j++)
                {
                    Board[i, j] = GameValues.Empty;
                }
            }
        }

        private void PlaceMines()
        {
            var random = new Random();
            for (int i = 0; i < NumberOfMines; i++)
            {
                var row = random.Next(0, BoardRows);
                var column = random.Next(0, BoardColumns);
                Board[row, column] = GameValues.Mine;
                PlaceNumber(row, column);
                Console.WriteLine(i);
            }            
        }

        private void PlaceNumber(int row, int column)
        {

            List<Point> surroundingCells = new List<Point> {
            new Point(row - 1, column - 1),
            new Point(row - 1, column),
            new Point(row - 1, column + 1),
            new Point(row, column + 1),
            new Point(row + 1, column + 1),
            new Point(row + 1, column),
            new Point(row + 1, column - 1),
            new Point(row , column - 1),
            };

            foreach (Point point in surroundingCells)
            {
                if (!((point.X < 0) || (point.Y < 0) || (point.X > BoardRows - 1) || (point.Y > BoardColumns - 1)))
                {
                    int currentValue = (int)Board[point.X, point.Y];
                    if (currentValue != 9)
                    {
                        currentValue += 1;
                    }
                    Board[point.X, point.Y] = (GameValues)currentValue;
                }
            }
        }
    }
}
