using VectorChallenge;

namespace VectorUnitTests
{
    /// <summary>
    /// TestClass for testing simple calculations with vectors
    /// </summary>
    [TestClass]
    public class VectorSimpleMathTests
    {


        /// <summary>
        /// Tests addition calculation of VectorMath
        /// </summary>
        [TestMethod]
        public void AddVector_AddVectors_ReturnsSum()
        {
            //Arrange
            Vector VectorA = new Vector(2, 2, 2);
            Vector VectorB = new Vector(2, 2, 2);

            //Act
            Vector VectorC = VectorSimpleMath.AddVector(VectorA, VectorB);
            
            //Assert
            Assert.AreEqual(VectorC.VectorX, 4);
            Assert.AreEqual(VectorC.VectorY, 4);
            Assert.AreEqual(VectorC.VectorZ, 4);
            
        }


        /// <summary>
        /// Tests Subt calculation of VectorMath
        /// </summary>
        [TestMethod]
        public void SubVector_SubstractVectors_ReturnsSum()
        {
            Vector VectorA = new Vector(2, 2, 2);
            Vector VectorB = new Vector(1, 1, 1);

            Vector VectorC = VectorSimpleMath.SubVector(VectorA, VectorB);

            Assert.AreEqual(VectorC.VectorX, 1);
            Assert.AreEqual(VectorC.VectorY, 1);
            Assert.AreEqual(VectorC.VectorZ, 1);
        }


        /// <summary>
        /// Tests dividing of VectorMath
        /// </summary>
        [TestMethod]
        public void DivSkalVector_DividesVectorWithSkalar_ReturnsSum()
        {
            Vector VectorA = new Vector(2, 2, 2);
            double Skalar = 2;

            Vector VectorC = VectorSimpleMath.DivSkalVector(VectorA, Skalar);
                        
            Assert.AreEqual(VectorC.VectorX, 1);
            Assert.AreEqual(VectorC.VectorY, 1);
            Assert.AreEqual(VectorC.VectorZ, 1);
        }


        /// <summary>
        /// Tests calculation of length of vector
        /// </summary>
        [TestMethod]
        public void LengthVector_CalculateVectorLength_ReturnsVectorLength()
        {
            Vector VectorA = new Vector(2, 3, 4);

            double Result = VectorSimpleMath.LengthVector(VectorA);
            Result = Math.Round(Result, 2);

            Assert.AreEqual(Result, 5.39);
        }


        /// <summary>
        /// Tests the AngleBetweenVectors calc of Vector
        /// </summary>
        [TestMethod]
        public void AngleBetweenVectors_CalculateAngleBetweenVectors_ReturnsAngle()
        {
            Vector VectorA = new Vector(4, -3, 5);
            Vector VectorB = new Vector(9, 7, -10);

            double Result = VectorComplexMath.AngleBetweenVectors(VectorA, VectorB);
            Result = Math.Round(Result, 2);

            Assert.AreEqual(Result, 109.05);
        }


        /// <summary>
        /// Tests the equalcheck of Vector
        /// </summary>
        [TestMethod]
        public void IsEqualVector_CheckEqualityBetweenVectors_ReturnsBool()
        {
            Vector VectorA = new Vector(2, 2, 2);
            Vector VectorB = new Vector(2, 2, 2);

            bool Result = VectorSimpleMath.IsEqualVector(VectorA, VectorB);

            Assert.AreEqual(true, Result);
        }


        /// <summary>
        /// Tests the negation of VectorMath
        /// </summary>
        [TestMethod]
        public void NegateVector_NegatesVector_ReturnsNegatedVector()
        {
            Vector VectorA = new Vector(2, 2, 2);

            Vector VectorC = VectorSimpleMath.NegateVector(VectorA);
                        
            Assert.AreEqual(VectorC.VectorX, -2);
            Assert.AreEqual(VectorC.VectorY, -2);
            Assert.AreEqual(VectorC.VectorZ, -2);
        }

    }
}