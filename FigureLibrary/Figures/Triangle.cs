using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        private bool isRectangular = false;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side of triangle should be a positive double");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            this.SideA = a; this.SideB = b; this.SideC = c;

            this.calculateArea(a, b, c);
            this.calculateIsRectangular(a, b, c);            
        }

        private void calculateArea(double a, double b, double c)
        {
            this.area = Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
        }

        private void calculateIsRectangular(double a, double b, double c)
        {
            double[] sides = new double[3] { a, b, c };
            Array.Sort(sides);
            this.isRectangular = Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= 0.0001;
        }

        public bool IsRectangular()
        {
            return this.isRectangular;
        }
    }
}
