using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius <= 0.0)
            {
                throw new ArgumentException("Radius should be a positive double");
            }

            this.Radius = radius;
                
            this.area = Math.PI * radius * radius;
        }
    }
}
