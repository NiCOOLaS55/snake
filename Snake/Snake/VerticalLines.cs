﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines
    {
        List<Point> plist;

        public VerticalLines(int yUp, int yDown, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }


    }
}
