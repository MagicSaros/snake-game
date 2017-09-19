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

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Move(Direction.UP);
                    break;
                case ConsoleKey.DownArrow:
                    Move(Direction.DOWN);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    Move(Direction.RIGHT);
                    break;
            }
        }

        private void Move(Direction direction)
        {

        }
    }
}
