using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yDown, int x, char symbol)
        {
            PointsList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                PointsList.Add(new Point(x, y, symbol));
            }
        }
    }
}
