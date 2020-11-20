using System;

namespace Structs
{
    public struct Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public override string ToString()
        {
           return "({x}, {y}, {z})";
        }

        public static Vector operator +(Vector a, Vector b)
        {
           return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vector operator *(Vector a, int s)
        {
            return new Vector(a.x * s, a.y * s, a.z * s);
        }

        public static Vector operator /(Vector a, int f)
        {
            return new Vector(a.x / f, a.y / f, a.z / f);
        }

        public Vector Normalize()
        {
            double s = Math.Sqrt(x * x + y * y + z * z);
            return new Vector(x / s, y / s, z / s);
        }

        public double GetLength()
        {
            double d = Math.Sqrt(x * x + y * y + z * z);
            return d;
        }
    }
}


