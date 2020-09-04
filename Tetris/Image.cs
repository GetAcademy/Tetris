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

        public Image(int width, int height, ConsoleColor[] colors = null)
        {
            _height = height;
            _width = width;
            _pixels = colors ?? new ConsoleColor[width * height];
        }

        public void Show(int offsetRow, int offsetCol)
        {
            for (var i = 0; i < _pixels.Length; i++)
            {
                var color = _pixels[i];
                var row = i / _width;
                var col = i % _width;
                Console.CursorTop = offsetRow + row;
                Console.CursorLeft = offsetCol + col;
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
