using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new[]
            {
                ConsoleColor.Yellow,
                ConsoleColor.Yellow,
                ConsoleColor.Yellow,
                ConsoleColor.Black,
                ConsoleColor.Yellow,
                ConsoleColor.Black,
            }; 
            var piece = new Piece(3, 2, colors);

            while (true)
            {
                Console.Clear();
                piece.Show();
                piece.Move(-1,0);
                Console.ReadLine();
            }

            //var image = new Image(3,2, colors);
            //image.Show();
        }
    }
}
