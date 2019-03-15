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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
                        
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(3, 2, '№');
            p3.Draw();

            Point p4 = new Point(5, 1, '$');
            p4.Draw();

            List<char> symlist = new List<char>
            {
                '*',
                '#',
                '№',
                '$'
            };

            List<Point> plist = new List<Point>
            {
                p1,
                p2,
                p3,
                p4
            };


            Console.ReadLine();
        }
    }
}
