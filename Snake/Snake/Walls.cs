using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> listWalls = new List<Figure>();


        public Walls()
        {
            char symbol = '*';
            listWalls.Add(new HorizontalLine(0, 0, symbol, 78));
            listWalls.Add(new HorizontalLine(1, 24, symbol, 76));
            listWalls.Add(new VerticalLine(0, 1, symbol, 23));
            listWalls.Add(new VerticalLine(78, 1, symbol, 23));
        }

        public void Draw()
        {
            foreach (Figure wall in listWalls)
            {
                wall.Draw();
            }
        }

    }
}
