using System;
using System.Drawing;

namespace GroupDMinefieldMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard("Beginner");
            var display = new Display();
            display.DisplayBoard(board);
            board.CheckCell(new Point(3, 4));
            display.DisplayBoard(board);
            board.CheckCell(new Point(0, 1));
            display.DisplayBoard(board);
            board.CheckCell(new Point(4, 6));
            display.DisplayBoard(board);

            
        }
    }
}
