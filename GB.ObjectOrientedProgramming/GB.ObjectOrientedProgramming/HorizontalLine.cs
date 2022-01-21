using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    internal class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            PointsList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                PointsList.Add(new Point(x, y, symbol));
            }
        }
    }
}
