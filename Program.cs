using System;

namespace GroupDMinefieldMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard board = new GameBoard("Expert");
            var display = new Display();
            display.DisplayBoard(board);
        }
    }
}
