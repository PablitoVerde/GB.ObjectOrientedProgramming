using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    class Point
    {
        private int x;
        private int y;
        private char symbol;

        public Point()
        {
                
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.symbol);
        }
    }
}
