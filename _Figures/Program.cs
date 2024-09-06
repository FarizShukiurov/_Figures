using _Figures.Interfaces;
using _Figures.Models;

namespace _Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = FigureFactory.CreateFigure("circle", 5);
            Console.WriteLine($"Area of ​​a circle: {circle.CalculateArea()}");

            IFigure triangle = FigureFactory.CreateFigure("triangle", 3, 4, 5);
            Console.WriteLine($"Area of ​​a triangle: {triangle.CalculateArea()}");

            Console.WriteLine($"Is the triangle rectangular? {((Triangle)triangle).isRightTriangle()}"); 
        }
    }
}
