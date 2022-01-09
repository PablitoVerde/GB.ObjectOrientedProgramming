using System;

namespace GB.ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        static void Draw (int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
