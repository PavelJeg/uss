using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uss
{
    internal class Snake : Figure
    {
        Direction direction;
        //корд хвоста, длина и направление
        public Snake(Point tail, int lenght, Direction direction)
        {
            direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();


            throw new NotImplementedException();
        }

        public Point GetNextPoint()
        {
           Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
           return nextPoint;
        }
        public void Handlekey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal void HandleKey(ConsoleKey key)
        {
            throw new NotImplementedException();
        }
    }
}
