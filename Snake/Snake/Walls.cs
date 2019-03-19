using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallist;

        public Walls(int mapWidth, int mapHeight)
        {
            wallist = new List<Figure>();
            
            /* рисуем рамку окна консоли*/
            HorizontalLines HUpline = new HorizontalLines(0, mapWidth - 2, 0, '+');
            HorizontalLines HDownline = new HorizontalLines(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLines VLeftline = new VerticalLines(0, mapHeight - 1, 0, '+');
            VerticalLines VRightline = new VerticalLines(0, mapHeight - 1, mapWidth - 2, '+');

            wallist.Add(HUpline);
            wallist.Add(HDownline);
            wallist.Add(VLeftline);
            wallist.Add(VRightline);            
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallist)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallist)
            {
                wall.Draw();
            }
        }
    }
}
