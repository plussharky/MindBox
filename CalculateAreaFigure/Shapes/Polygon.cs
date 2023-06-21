using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaFigure.Shapes
{
    internal class Polygon : ICalculateArea
    {
        private double[] sides;

        public Polygon(double[] sides)
        {
            this.sides = sides;
        }
        public double CalculateArea()
        {
            if (IsRightPolygon() == false)
                throw new Exception("Cannot calculate this");
            double p = sides.Sum();
            double a = sides[0] / (2 * Math.Tan(Math.PI / sides.Length));
            return p * a / 2;
        }

        private bool IsRightPolygon()
        {
            return sides.All(x => Math.Abs(x - sides[0]) < 0.00001);
        }
    }
}
