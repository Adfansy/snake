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

            Walls walls = new Walls( 78,24 );
            walls.Draw();
                        
            // отрисовка точек
            Point p = new Point(7, 12, '*');
            Snake Snake = new Snake( p, 4, Direction.RIGHT );
            Snake.Draw();

            FoodCreator foodCreator = new FoodCreator( 78, 24, '$' );
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
        }       
    }
}
