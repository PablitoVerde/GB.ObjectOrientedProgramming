using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    class Figure
    {
        protected List<Point> PointsList;

        public void Draw()
        {
            foreach (var p in PointsList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in PointsList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in PointsList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
