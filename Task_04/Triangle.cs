using System;
using System.Collections.Generic;
using System.Text;

namespace Task_04
{
    /// <summary>
    /// Triangle class.
    /// It takes 3 arguments, which are the lengths of its sides.
    /// When creating an instance, the possibility of the existence
    /// of a triangle with the specified parameters is automatically checked.
    /// </summary>
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private Triangle() { }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (!PossibleTriangle(a, b, c))
                throw new ArgumentException("Не существует треугольника с заданными параметрами");
        }

        public double SideA
        {
            get { return a; }
        }
        public double SideB
        {
            get { return b; }
        }
        public double SideC
        {
            get { return c; }
        }
        public double Perimeter
        {
            get { return PerimeterTriangle(a, b, c); }
        }
        public double Square
        {
            get { return SquareTriangle(a, b, c); }
        }
        /// <summary>
        /// Method for testing the possibility of the existence of a triangle with given parameters.
        /// </summary>
        /// <returns>
        /// True if it is possible.
        /// </returns>
        public bool PossibleTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }
        /// <summary>
        /// Perimeter.
        /// </summary>
        /// <returns>
        /// Perimeter of the triangle.
        /// </returns>
        public double PerimeterTriangle(double a, double b, double c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Square.
        /// The formula uses a semi-perimeter.
        /// </summary>
        /// <returns>
        /// Square of the triangle.
        /// </returns>

        public double SquareTriangle(double a, double b, double c)
        {
            double p = PerimeterTriangle(a, b, c) / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
        }

    }
}
