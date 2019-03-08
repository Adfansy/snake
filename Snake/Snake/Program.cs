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

            Walls walls = new Walls( 80,25 );
            walls.Draw();
                        
            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake Snake = new Snake( p, 4, Direction.RIGHT );
            Snake.Draw();

            FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
            Point food = foodCreator.CreatFood();
            food.Draw();

            while(true)
            {

                if ( walls.IsHit(Snake) || Snake.IsHitTail() )
                {
                    break;
                }
                if (Snake.Eat( food ) )
                {
                    food = foodCreator.CreatFood();
                    food.Draw();
                }
                else
                {
                    Snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.HandleKey( key.Key );
                }                
            }
            WriteGameOver();
            Console.ReadLine();
        }
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
