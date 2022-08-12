using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorChallenge
{
    //Klasse fuer komplexe Berechnungen mit Vektoren
    //Init am 05.08.2022 - Ferdinand Marx

    /// <summary>
    /// Class for doing complex calculations with vectors.
    /// </summary>
    public class VectorComplexMath : VectorSimpleMath
    {

        /// <summary>
        /// Calculates the scalar product of two vectors.
        /// </summary>
        /// <param name="a">VectorA for calculation</param>
        /// <param name="b">VectorB for calculation</param>
        /// <returns>Scalarproduct of calculation (double)</returns>
        public static double SkalProductVector(Vector a, Vector b)
        {
            double skalVectorProd = 0;
            skalVectorProd += a.VectorX * b.VectorX;
            skalVectorProd += a.VectorY * b.VectorY;
            skalVectorProd += a.VectorZ * b.VectorZ;
            return skalVectorProd;
        }


        /// <summary>
        /// Calculates the crossprodct of two vectors.
        /// </summary>
        /// <param name="a">VectorA for calculation</param>
        /// <param name="b">VectorB for calculation</param>
        /// <returns>Vectormath new Vector</returns>
        public static Vector CrossProductVector(Vector a, Vector b)
        {
            return new Vector(a.VectorY * b.VectorZ - a.VectorZ * b.VectorY, a.VectorZ * b.VectorX - a.VectorX * b.VectorZ, a.VectorX * b.VectorY - a.VectorY * b.VectorX);
        }


        /// <summary>
        /// Calculates the angle between two vectors.
        /// </summary>
        /// <param name="a">VectorA for calculation</param>
        /// <param name="b">VectorB for calculation</param>
        /// <returns>The Angle between two vectors (double)</returns>
        public static double AngleBetweenVectors(Vector a, Vector b)
        {
            //Benoetigte Vars initialisieren
            double radians = 0;
            double angle = 0;
            double ab = 0;
            double aa = 0;
            double bb = 0;
            double cos0 = 0;

            //Berechnung erst nach rad, dann Winkel
            ab = a.VectorX * b.VectorX + a.VectorY * b.VectorY + a.VectorZ * b.VectorZ;
            aa = Math.Pow(a.VectorX, 2) + Math.Pow(a.VectorY, 2) + Math.Pow(a.VectorZ, 2);
            bb = Math.Pow(b.VectorX, 2) + Math.Pow(b.VectorY, 2) + Math.Pow(b.VectorZ, 2);
            cos0 = Math.Sqrt(aa) * Math.Sqrt(bb);
            cos0 = ab / cos0;
            radians = Math.Acos(cos0);
            angle = radians * (180 / Math.PI);

            return Math.Round(angle, 2);
        }


    }
}
