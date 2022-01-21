using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;

            PointsList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PointsList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = PointsList[0];
            PointsList.Remove(tail);
            Point head = GetNextPoint();
            PointsList.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = PointsList[PointsList.Count - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void ChangeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                PointsList.Add(food);
                return true;
            }
            else
                return false;
        }

        internal bool IsHitTail()
        {
            var head = PointsList[PointsList.Count - 1];
            for (int i = 0;i<PointsList.Count-2;i++)
            {
                if (head.IsHit(PointsList[i]))
                    return true;
            }
            return false;
        }
    }
}
