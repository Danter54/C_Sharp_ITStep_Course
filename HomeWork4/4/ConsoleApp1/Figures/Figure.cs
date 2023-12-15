using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Figure
    {
        private int _x;
        private int _y;

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public Figure()
        {
            X = 0;
            Y = 0;
        }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Figure x:{X}, y:{Y}";
        }
    }
}
