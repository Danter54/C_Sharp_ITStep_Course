using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Squere : Figure
    {
        private double _side;

        public double Side { get { return _side; } set { _side = value; } }
        public Squere()
        {
            Side = 0;
        }
        public Squere(double side)
        {
            Side = side;
        }

        public double GetSquere() => Math.Pow(Side, 2);

        public double GetPerimetr() => 4.0 * Side;

        public bool IsBigger(Squere squere) => GetSquere() > squere.GetSquere();

        public override string ToString()
        {
            return $"Squere with side:{Side}";
        }
    }
}
