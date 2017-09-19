using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xStart, int yStart, char symbol, int length)
        {
            listPoints = new List<Point>();
            for (int x = xStart; x <= xStart + length; x++)
            {
                Point point = new Point(x, yStart, symbol);
                listPoints.Add(point);
            }
        }
    }
}
