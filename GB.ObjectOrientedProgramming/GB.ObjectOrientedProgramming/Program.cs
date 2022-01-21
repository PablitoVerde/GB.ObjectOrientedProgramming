using System;
using System.Collections.Generic;
using System.Threading;

namespace GB.ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point tailPoint = new Point(5, 4, 'x');

            Snake snake = new Snake(tailPoint, 7, Direction.Down);
            snake.Draw();

            Food food = new Food(80, 25, '#');
            Point f = food.MakeFood();
            f.Draw();

            bool showMenu = true;

            while (showMenu)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(f))
                {
                    f = food.MakeFood();
                    f.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(500);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Spacebar)
                        showMenu = false;
                    else
                        snake.ChangeDirection(key.Key);


                }

            }

            Console.ReadKey();
        }
    }
}
