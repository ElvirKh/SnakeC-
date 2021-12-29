using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            points = new List<Point>();
            for (int i=0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i,direction);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1,direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;

        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                points.Add(food);
                return true;
            }
            else 
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            var head = points.Last();
            for (int i=0; i<points.Count-2; i++)
            {
                if (head.IsHit(points[i]))
                    return true;
            }
            return false;
        }

    }
}
