using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
             /* устанавливаем размер окна консоли*/
            Console.SetBufferSize( 80, 25 );
            /* рисуем рамку окна консоли*/

            HorizontalLines HUpline = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines HDownline = new HorizontalLines(0, 78, 24, '+');
            VerticalLines VLeftline = new VerticalLines(0, 24, 0, '+');
            VerticalLines VRightline = new VerticalLines(0, 24, 78, '+');
            HUpline.Draw();
            HDownline.Draw();
            VLeftline.Draw();
            VRightline.Draw();

            /* отрисовка точек*/
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
               
            }
                          
        }
    }
}
