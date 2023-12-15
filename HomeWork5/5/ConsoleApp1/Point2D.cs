using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point2D
    {
        private int _x, _y;
        private double length;

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public Point2D()
        {
            X = Y  = 0;
            length = 0;
        }
        public Point2D(int x, int y)
        {
            X = x;  Y = y;
            SetLength();
        }

        public void SetRandomValue()
        {
            Random random = new Random();
            X = random.Next(1, 99);
            Y = random.Next(1, 99);
            SetLength();
        }

        public void SetValueFromString(string line)
        {
            string[] values = line.Split(' ');

            X = int.Parse(values[0]);
            Y = int.Parse(values[1]);
            SetLength();
        }

        public void SetLength()
        {
            length = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
        public double GetLength(){return length;}

        public override string ToString()
        {
            return $"{X} {Y}";
        }

    }
}
