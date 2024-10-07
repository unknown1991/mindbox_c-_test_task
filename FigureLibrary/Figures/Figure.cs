using FigureLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public abstract class Figure
    {
        protected double area;

        public double GetArea()
        {
            return area;
        }

        public static Figure CreateFigure(string fullClassName, params object[] args)
        {
            var type = Type.GetType(fullClassName);

            if (type is not null)
            {
                Figure figure = (Figure?)Activator.CreateInstance(type, args) ?? throw new ArgumentException("Figure object wasn't created.");
                return figure;
            }       
		    else
            {
                throw new ArgumentException("Provided type doesn't exist");
            }
        }

        public override string ToString() =>
            $"Figure type: {this.GetType().Name}, Area = {area:F3}";
    }
}
