using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> pList = new List<Point>();
            pList.Add(new Point(1, 2, '#'));
            pList.Add(new Point(3, 4, '/'));
            pList.Add(new Point(5, 6, '='));
            pList.Add(new Point(7, 8, '*'));
            foreach (Point i in pList)
            {
                i.Draw();
            }

            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(16, 14, '/');
            p3.Draw();

            Point p4 = new Point(7, 12, '=');
            p4.Draw();

            List<Point> pList = new List<Point>();
            pList.Add( p1 );
            pList.Add( p2 );
            pList.Add( p3 );
            pList.Add( p4 );

            List<char> cList = new List<char>();
            cList.Add( '*' );
            cList.Add( '#' );
            cList.Add( '/' );
            cList.Add( '=' );
            foreach (int i in cList)
            {
                Console.WriteLine(i);
            }

                    /*List<int> numList = new List<int>();
                    numList.Add( 0 );
                    numList.Add( 1 );
                    numList.Add( 2 );
                    numList.Add( 3 );
                    numList.Add( 4 );

                    int x = numList[ 2 ];
                    int y = numList[ 4 ];
                    int z = numList[ 3 ];

                    foreach(int i in numList)
                    {
                        Console.WriteLine( i );
                    }

                    numList.RemoveAt( 0 );*/

            Console.ReadLine();
}
       
    }
}
