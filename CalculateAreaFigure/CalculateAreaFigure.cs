using CalculateAreaFigure.Shapes;

namespace CalculateAreaFigure
{
    public static class CalculateAreaFigure
    {
        public static double CalculateArea(params double[] sides)
        {
            ICalculateArea? calculateArea = null;
            if (sides.Length == 0 || sides.Length == 2)
                throw new ArgumentException("Wrong number of sides");
            switch (sides.Length)
            {
                case 0:
                    case 2: throw new Exception("Wrong number of sides");
                case 1: calculateArea = new Circle(sides[0]); break;
                case 3: calculateArea = new Triangle(sides); break;
                default: calculateArea = new Polygon(sides); break;
            }
            return calculateArea.CalculateArea();
        }
    }
}