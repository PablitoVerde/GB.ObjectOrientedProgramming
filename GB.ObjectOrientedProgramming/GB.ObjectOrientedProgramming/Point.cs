using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    class Point
    {
        int x;
        int y;
        public char symbol;

        public Point()
        {

        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x += offset;
            }
            else if (direction == Direction.Left)
            {
                x -= offset;
            }
            else if (direction == Direction.Up)
            {
                y -= offset;
            }
            else if (direction == Direction.Down)
            {
                y += offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public bool IsHit(Point point)
        {
            return point.x == this.x && point.y == this.y;
        }
    }
}
