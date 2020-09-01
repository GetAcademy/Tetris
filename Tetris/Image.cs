using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Image
    {
        private ConsoleColor[] _pixels;
        private int _width;
        private int _height;

        public Image(int width, int height)
        {
            _height = height;
            _width = width;
            _pixels = new ConsoleColor[width * height];
        }

        public void Show()
        {
            Console.Clear();
            for (var i = 0; i < _pixels.Length; i++)
            {
                if (i > 0 && i % _width == 0) Console.WriteLine();
                var color = _pixels[i];
                Console.ForegroundColor = color;
                Console.Write("█");
            }
        }

        public void SetPixelColor(int col, int row, ConsoleColor color)
        {
            var index = row * _width + col;
            _pixels[index] = color;
        }
    }
}
