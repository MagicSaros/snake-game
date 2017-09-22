using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> listPoints;

        public void Draw()
        {
            foreach (Point point in listPoints)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (Point point in listPoints)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHit(Point figurePoint)
        {
            foreach (Point point in listPoints)
            {
                if (point.IsHit(figurePoint))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
