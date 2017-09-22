using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        private int height;
        private int width;
        private char symbol;

        Random rnd = new Random();

        public Food(int height, int width, char symbol)
        {
            this.height = height;
            this.width = width;
            this.symbol = symbol;
        }

        public Point Create()
        {
            int x = rnd.Next(1, height - 2);
            int y = rnd.Next(1, width - 2);
            return new Point(x, y, symbol);
        }
    }
}
