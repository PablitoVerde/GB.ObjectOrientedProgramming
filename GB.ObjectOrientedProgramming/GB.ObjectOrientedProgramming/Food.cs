using System;
using System.Collections.Generic;
using System.Text;

namespace GB.ObjectOrientedProgramming
{
    internal class Food
    {
        int mapWidth, mapHeight;
        char symbol;

        Random random = new Random();

        public Food(int mapWidth, int mapHeight, char symbol)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symbol = symbol;
        }

        public Point MakeFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symbol);
        }
    }
}
