using System;

namespace CSharpEducation.Practice3;
class Point
{
    public double X { get; set; }
    public double Y{ get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistancesBetweenTwoPoints(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
    }
}