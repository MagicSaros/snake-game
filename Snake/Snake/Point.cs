using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        protected void Shift(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    this.y = this.y - offset;
                    break;
                case Direction.DOWN:
                    this.y = this.y + offset;
                    break;
                case Direction.LEFT:
                    this.x = this.x - offset;
                    break;
                case Direction.RIGHT:
                    this.x = this.x + offset;
                    break;
            }
        }

        public void Clear()
        {
            this.symbol = ' ';
            this.Draw();
        }
    }
}
