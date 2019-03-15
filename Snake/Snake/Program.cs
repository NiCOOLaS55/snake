using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
             /* устанавливаем размер окна консоли*/
            Console.SetBufferSize( 80, 25 );
            /* рисуем рамку окна консоли*/

            HorizontalLines HUpline = new HorizontalLines(0, 78, 0, '*');
            HorizontalLines HDownline = new HorizontalLines(0, 78, 24, '*');
            VerticalLines VLeftline = new VerticalLines(0, 24, 0, '*');
            VerticalLines VRightline = new VerticalLines(0, 24, 78, '*');
            HUpline.Draw();
            HDownline.Draw();
            VLeftline.Draw();
            VRightline.Draw();

            /* отрисовка точек*/
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
