using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int xStart, int yStart, char symbol, int length)
        {
            listPoints = new List<Point>();
            for (int y = yStart; y <= yStart + length; y++)
            {
                Point point = new Point(xStart, y, symbol);
                listPoints.Add(point);
            }
        }
    }
}
