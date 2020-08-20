using System;

namespace GroupDMinefieldMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard("Beginner");

            int sum = 0;
            for (int i = 0; i < board.BoardRows; i++)
            {
                for (int j = 0; j < board.BoardColumns; j++)
                {
                    if (board.Board[i, j].CellValue == GameValues.Mine)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
