using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace app_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(62, 52);

            //Drawing frame
            HorizontalLine upLine = new HorizontalLine(0, 60, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 60, 50, '+');
            VerticalLine leftLine = new VerticalLine(0, 50, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 50, 60, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Drawing point
            Point p = new Point(4, 10, '#');

            Snake snake = new Snake(p, 4, Direction.RIGTH);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if(key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGTH;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }
           
            Console.ReadLine();
        }
    }
}
