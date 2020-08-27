using System;
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
        public bool Equals(Vector other)
        {
            //if (ReferenceEquals(null, other))
            //    return false;
            //if (ReferenceEquals(this, other))
            //    return true;
            //return double.Equals(x, other.x) && double.Equals(y, other.y) && double.Equals(z, other.z);
            return Equals(x, other.x) && Equals(y, other.y) && Equals(z, other.z);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vector)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                //return ((x != null ? x.GetHashCode() : 0) * 397) ^ (y != null ? y.GetHashCode() : 0) ^ (z != null ? z.GetHashCode() : 0);
                return HashCode.Combine(x, y, z);
            }
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
