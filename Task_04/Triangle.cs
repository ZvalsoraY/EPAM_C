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
        /// <summary>
        /// Method for testing the possibility of the existence of a triangle with given parameters.
        /// </summary>
        public bool PossibleTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }
        /// <summary>
        /// The method returns the perimeter of the triangle.
        /// </summary>
        public double PerimeterTriangle(double a, double b, double c)
        {
            return a + b + c;
        }
        /// <summary>
        /// The method returns the square of the triangle.
        /// The formula uses a semi-perimeter.
        /// </summary>
        public double SquareTriangle(double a, double b, double c)
        {
            double p = PerimeterTriangle(a, b, c) / 2;
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
        }

    }
}
