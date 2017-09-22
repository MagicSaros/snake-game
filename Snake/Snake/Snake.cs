using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            listPoints = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Shift(i, direction);
                listPoints.Add(point);
            }
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
            }
        }

        public void Move()
        {
            Point tail = listPoints.First();
            listPoints.Remove(tail);
            tail.Clear();

            Point head = GetNextPosition();
            listPoints.Add(head);
            head.Draw();
        }

        private Point GetNextPosition()
        {
            Point head = listPoints.Last();
            Point nextPoint = new Point(head);
            nextPoint.Shift(1, direction);
            return nextPoint;
        }

        public bool Eat(Point food)
        {
            Point nextPoint = GetNextPosition();
            if (nextPoint.IsHit(food))
            {
                food.symbol = nextPoint.symbol;
                listPoints.Add(food);
                return true;
            }
            return false;
        }

        public bool IsHitTail()
        {
            Point head = listPoints.Last();
            for (int i = 0; i < listPoints.Count - 2; i++)
            {
                if (head.IsHit(listPoints[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
