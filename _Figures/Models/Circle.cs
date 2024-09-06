using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Figures.Interfaces;

namespace _Figures.Models
{
    public class Circle : IFigure
    {
        public double Radius { get; }
        public Circle(double radius) {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
