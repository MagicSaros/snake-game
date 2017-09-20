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
            Point newHead = new Point(head);
            newHead.Shift(1, direction);
            return newHead;
        }
    }
}
