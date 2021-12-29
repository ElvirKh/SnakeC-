using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
       public int x;
       public int y;
       public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public Point()
        {

        }

        public Point(int x0, int y0, char symb0)
        {
            x = x0;
            y = y0;
            symbol = symb0;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;

        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offset;
            else if (direction == Direction.LEFT)
                x = x - offset;
            else if (direction == Direction.UP)
                y = y - offset;
            else if (direction == Direction.DOWN)
                y = y + offset;
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
