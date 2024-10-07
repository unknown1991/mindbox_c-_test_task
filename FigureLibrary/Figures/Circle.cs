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
        public Circle(double r)
        {
            if (r <= 0.0)
            {
                throw new ArgumentException("Radius should be a positive double");
            }
                
            this.area = Math.PI * r * r;
        }
    }
}
