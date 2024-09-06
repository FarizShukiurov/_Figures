using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Figures.Interfaces;
namespace _Figures.Models
{
    public static class FigureFactory
    {
        public static IFigure CreateFigure(string figureType, params double[] parameters)
        {
            switch (figureType.ToLower())
            {
                case "circle":
                    if (parameters.Length == 1)
                    {
                        return new Circle(parameters[0]);
                    }
                    throw new ArgumentException("A circle requires 1 parameter - radius.");
                case "triangle":
                    if (parameters.Length == 3)
                    {
                        return new Triangle(parameters[0], parameters[1], parameters[2]);
                    }
                    throw new ArgumentException("A triangle requires 3 parameters - sides.");
                default:
                    throw new ArgumentException("Unknown figure type.");
            }
        }
    }
}
