using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CalculateAreaFigure.Shapes
{
    internal sealed class Triangle : ICalculateArea
    {
        private double[] sides;

        public Triangle(double[] sides)
        {
            this.sides = sides;
        }

        double ICalculateArea.CalculateArea()
        {
            if (IsRightTriangle())
                // looking for the legs of a triangle and counting the area through them
                return sides[0] > sides[1] ?
                    sides[0] > sides[2] ? CalculateAreaRightTriangle(sides[1], sides[2])
                    : CalculateAreaRightTriangle(sides[0], sides[1])
                    : sides[1] > sides[2] ? CalculateAreaRightTriangle(sides[0], sides[2])
                    : CalculateAreaRightTriangle(sides[0], sides[1]);
            double p = sides.Sum() / 2;
            return Math.Sqrt(p * (p - sides[0])
                * (p - sides[1]) * (p - sides[2]));
        }

        private bool IsRightTriangle()
        {
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.00001
                || Math.Abs(Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2)) < 0.00001
                || Math.Abs(Math.Pow(sides[2], 2) + Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 0.00001;
        }

        private double CalculateAreaRightTriangle(double a, double b)
        {
            return  (a * b) / 2;
        }
    }
}
