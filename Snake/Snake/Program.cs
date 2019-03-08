using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 120, 30 );

            // отрисовка рамки           
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            upline.Draw();
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Draw();
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Draw();
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Draw();

            // отрисовка точек
            Point p = new Point(7, 12, '*');
            Snake Snake = new Snake( p, 4, Direction.RIGHT );
            Snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey( key.Key );
                }
                Thread.Sleep(100);
                Snake.Move();
            }
            Console.ReadLine();
        }
       
    }
}
