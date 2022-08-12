using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VectorChallenge
{
    //Klasse fuer einfache Berechnungen mit Vektoren
    //Init am 05.08.2022 - Ferdinand Marx


    /// <summary>
    /// Class for doing simple calculations with vectors.
    /// </summary>
    public class VectorSimpleMath
    {

        /// <summary>
        /// Calculates the sum of two vectors.
        /// </summary>
        /// <param name="a">First Vector for calculation</param>
        /// <param name="b">Second Vector for calculation</param>
        /// <returns>VectorMath new Vector</returns>
        public static Vector AddVector(Vector a, Vector b)
        {
            return new Vector(a.VectorX + b.VectorX, a.VectorY + b.VectorY, a.VectorZ + b.VectorZ);
        }


        /// <summary>
        /// Subtracts vectors. VectorA - VectorB
        /// </summary>
        /// <param name="a">First Vector for calculation</param>
        /// <param name="b">Second Vector for calculation</param>
        /// <returns>VectorMath new Vector</returns>
        public static Vector SubVector(Vector a, Vector b)
        {
            return new Vector(a.VectorX - b.VectorX, a.VectorY - b.VectorY, a.VectorZ - b.VectorZ);
        }


        /// <summary>
        /// Multiplicates a Vector with a scalar (real number).
        /// </summary>
        /// <param name="a">Vector for calculation</param>
        /// <param name="n">Scalar (real number) for calculation</param>
        /// <returns>VectorMath new Vector</returns>
        public static Vector MultSkalVector(Vector a, double n)
        {
            return new Vector(a.VectorX * n, a.VectorY * n, a.VectorZ * n);
        }


        /// <summary>
        /// Divides a vector with a skalar.
        /// </summary>
        /// <param name="a">Vector for calculation</param>
        /// <param name="n">Scalar (real number) for calculation</param>
        /// <returns>VectorMath new Vector</returns>
        public static Vector DivSkalVector(Vector a, double n)
        {

            if (n == 0)
            {
                MessageBox.Show($"Division durch 0 nicht möglich!{Environment.NewLine}Es wird durch 1 geteilt.");
                n = 1;
            }

            return new Vector(a.VectorX / n, a.VectorY / n, a.VectorZ / n);

        }


        /// <summary>
        /// Calculates the length of a given Vector.
        /// </summary>
        /// <param name="a">Vector for calculation</param>
        /// <returns>The length of a Vector (double)</returns>
        public static double LengthVector(Vector a)
        {
            return Math.Sqrt(a.VectorX * a.VectorX + a.VectorY * a.VectorY + a.VectorZ * a.VectorZ);
        }


        /// <summary>
        /// Checks if two vectors are equal.
        /// </summary>
        /// <param name="a">VectorA to check</param>
        /// <param name="b">VectorB to check</param>
        /// <returns>True or False (bool)</returns>
        public static bool IsEqualVector(Vector a, Vector b)
        {
            bool equalCheckState = false;

            if (a.VectorX == b.VectorX && a.VectorY == b.VectorY && a.VectorZ == b.VectorZ)
            {
                equalCheckState = true;
            }

            return equalCheckState;
        }


        /// <summary>
        /// Negates a given vector.
        /// </summary>
        /// <param name="a">Vector to negate</param>
        /// <returns>The negation of a given vector</returns>
        public static Vector NegateVector(Vector a)
        {
            return new Vector(a.VectorX * -1, a.VectorY * -1, a.VectorZ * -1);
        }


    }
}
