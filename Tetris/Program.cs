using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image(3,2);
            image.SetPixelColor(0, 0, ConsoleColor.Red);
            image.SetPixelColor(1, 0, ConsoleColor.White);
            image.SetPixelColor(2, 0, ConsoleColor.Blue);
            image.SetPixelColor(0, 1, ConsoleColor.Green);
            image.SetPixelColor(1, 1, ConsoleColor.DarkGreen);
            image.SetPixelColor(2, 1, ConsoleColor.Yellow);
            image.Show();
        }
    }
}
