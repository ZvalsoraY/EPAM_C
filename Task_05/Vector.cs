﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_05
{
    /// <summary>
    /// Vector class.
    /// A vector is specified by one point, that is, it has its origin at the origin.
    /// It takes 3 arguments x y z coordinates.
    /// </summary>
    public class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Length.
        /// </summary>
        /// <returns>
        /// Vector length.
        /// </returns>
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        /// <summary>
        /// Summ.
        /// </summary>
        /// <returns>
        /// The sum of two vectors.
        /// </returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
        /// <summary>
        /// Difference.
        /// </summary>
        /// <returns>
        /// The difference of two vectors.
        /// </returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.y - v2.y);
        }
        /// <summary>
        /// Dot product.
        /// </summary>
        /// <returns>
        /// Dot product of two vectors.
        /// </returns>
        public static double operator *(Vector v1, Vector v2)
        {
            return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
        }
        /// <summary>
        /// Multiplying.
        /// </summary>
        /// <returns>
        /// Multiplying a vector by a number.
        /// </returns>
        public static double operator *(Vector v1, double number)
        {
            return (v1.x * number + v1.y * number + v1.z * number);
        }
        /// <summary>
        /// To string.
        /// </summary>
        /// <returns>
        /// Method for forming a string representation of a "vector".
        /// </returns>
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", x, y, z);
        }
    }
}
