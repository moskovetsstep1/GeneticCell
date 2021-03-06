﻿namespace GenericLife.Core.Types
{
    public class Coordinate
    {
        public Coordinate(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; }
        public int Y { get; }

        public static Coordinate operator +(Coordinate left, Coordinate right)
        {
            int newX = left.X + right.X;
            int newY = left.Y + right.Y;
            return new Coordinate(newX, newY);
        }
    }
}