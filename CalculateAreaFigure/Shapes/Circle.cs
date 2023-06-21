using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaFigure.Shapes
{
    internal sealed class Circle : ICalculateArea
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public double CalculateArea()
        {
            return Math.PI * r * r;
        }
    }
}
