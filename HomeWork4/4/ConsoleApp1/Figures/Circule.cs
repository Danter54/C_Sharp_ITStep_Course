using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Circule : Figure
    {
        private double _radius;

        public double Radius { get { return _radius; } set { _radius = value; } }

        public Circule()
        {
            Radius = 0;
        }
        public Circule(double radius)
        {
            Radius = radius;
        }

        public bool IsBigger(Circule circ) => GetSquere() > circ.GetSquere();

        public double GetSquere() => Math.PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2.0 * Math.PI * Radius;

        public override string ToString()
        {
            return $"Circule with radius:{Radius}";
        }
    }
}
