using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> cList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            cList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                cList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in cList)
            {
                p.Draw();
            }
        }
    }
}
