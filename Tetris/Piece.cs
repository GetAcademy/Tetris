using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Piece
    {
        private Image _image;
        private int _row;
        private int _col;

        public Piece(int width, int height, ConsoleColor[] colors = null)
        {
            _image = new Image(width, height, colors);
            _row = 20;
        }

        public void Move(int deltaRow, int deltaCol)
        {
            _row += deltaRow;
            _col += deltaCol;
        }

        public void Rotate()
        {

        }

        public void Show()
        {
            _image.Show(_row, _col);
        }
    }
}
