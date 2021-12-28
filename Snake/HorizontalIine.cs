using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalIine : Figure
    {

        
        public HorizontalIine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, symbol);
                points.Add(p);

            }
        }

    }
}
