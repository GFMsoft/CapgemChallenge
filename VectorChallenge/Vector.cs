using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorChallenge
{
    //Klasse zum Erstellen von Vektoren
    //Init am 05.08.2022 - Ferdinand Marx


    /// <summary>
    /// Class for creating 3D vectors
    /// </summary>
    public class Vector
    {

        private double VectorXCoord, VectorYCoord, VectorZCoord;

        /// <summary>
        /// Constructor for vectors
        /// </summary>
        /// <param name="x">Double X coordinate</param>
        /// <param name="y">Double Y coordinate</param>
        /// <param name="z">Double Z coordinate</param>
        public Vector(double XCoord, double YCoord, double ZCoord)
        {
            VectorXCoord = XCoord;
            VectorYCoord = YCoord;
            VectorZCoord = ZCoord;
        }

        /// <summary>
        /// Getter for X-Coordinate
        /// </summary>
        public double VectorX
        {
            get { return VectorXCoord; }
        }

        /// <summary>
        /// Getter for Y-Coordinate
        /// </summary>
        public double VectorY
        {
            get { return VectorYCoord; }
        }

        /// <summary>
        /// Getter for Z-Coordinate
        /// </summary>
        public double VectorZ
        {
            get { return VectorZCoord; }
        }


    }
}
