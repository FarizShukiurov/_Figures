using _Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Figures.Models
{
    public class Triangle : IFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Sides must be greater than 0");
            }
            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Such a triangle is impossible");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }
        public bool isRightTriangle()
        {
            double hypotenuse = Math.Max(Side1, Math.Max(Side2, Side3));
            double leg1, leg2;

            if (hypotenuse == Side1)
            {
                leg1 = Side2;
                leg2 = Side3;
            }
            else if (hypotenuse == Side2)
            {
                leg1 = Side1;
                leg2 = Side3;
            }
            else
            {
                leg1 = Side1;
                leg2 = Side2;
            }
            return (hypotenuse * hypotenuse) == ((leg1*leg1)+(leg2*leg2));
        }
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
