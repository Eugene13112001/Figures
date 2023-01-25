using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLib;

namespace MindBoxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Площадь круга = {circle.Square()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника = {triangle.Square()}");
            
            if (triangle.IsSquareness) Console.WriteLine("Треугольник прямоугольный");
            else Console.WriteLine("Треугольник не прямоугольный");
            
        }
    }
}