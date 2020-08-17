using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GroupDMinefieldMidterm
{
    public class GameBoard
    {
        public int BoardRows { get; set; }
        public int BoardColumns { get; set; }
        public int NumberOfMines { get; set; }
        public GameValues[,] Board { get; set; }
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
                Board[row,column] = GameValues.Mine;
            }
        }

        private void PlaceNumber(int row, int column)
        {
            if(row < 0 || column < 0 || row > BoardRows || column > BoardColumns)
                
            TopLeft = row-1, column -1
            TopMiddle = row -1, column
            TopRight = row - 1, column +1
            MiddleRight = row, column +1
            BottomRight = row +1, column +1
            BottomMiddle = row +1, column
            BottomLeft = row -1, column -1
            MiddleLeft = row, column -1

        }


    }
}
