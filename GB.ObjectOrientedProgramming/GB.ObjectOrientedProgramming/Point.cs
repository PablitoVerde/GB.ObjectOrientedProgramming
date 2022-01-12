using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
