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
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
