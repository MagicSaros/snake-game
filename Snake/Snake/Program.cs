using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls();
            walls.Draw();

            Point point = new Point(5, 5, '#');
            Snake snake = new Snake(point, 4, Direction.RIGHT);
            snake.Draw();

            Food food = new Food(80, 25, '%');
            Point foodItem = food.Create();
            foodItem.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(foodItem))
                {
                    foodItem = food.Create();
                    foodItem.Draw();
                    snake.Move();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.Clear();
            Console.SetCursorPosition(34, 12);
            Console.WriteLine("Game over");
            Console.ReadKey();
        }
    }
}
