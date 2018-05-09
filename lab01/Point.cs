using System;

namespace lab01
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distanceTo(Point point)
        {
            return Math.Sqrt(Math.Pow(x - point.x, 2) + Math.Pow(y - point.y, 2));
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}