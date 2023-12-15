using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    internal class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA { get { return _sideA; } set { _sideA = value; } }
        public double SideB { get { return _sideB; } set { _sideB = value; } }
        public double SideC { get { return _sideC; } set { _sideC = value; } }

        public Triangle()
        {
            SideA = SideB = SideC = 0;
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetSquere()
        {
            return Math.Sqrt(GetPerimeter() / 2
                * (GetPerimeter() / 2 - SideA)
                * (GetPerimeter() / 2 - SideB)
                * (GetPerimeter() / 2 - SideC));
        }
        public double GetPerimeter() => SideA + SideB + SideC;

        public bool IsBigger(Triangle triag) => GetSquere() > triag.GetSquere();

        public override string ToString()
        {
            return $"Triangle with sides:{SideA}, {SideB}, {SideC}";
        }
    }
}
