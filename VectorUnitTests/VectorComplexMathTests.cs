using VectorChallenge;

namespace VectorUnitTests
{

    /// <summary>
    /// Testclass for testing complex calculations with vectors
    /// </summary>
    [TestClass]
    public class VectorComplexMathTests
    {


        /// <summary>
        /// Tests multiplication of VectorMath
        /// </summary>
        [TestMethod]
        public void MultSkalVector_MultiplyVectorWithSkalar_ReturnsSum()
        {
            //Arrange
            Vector VectorA = new Vector(2, 2, 2);
            double Skalar = 2;

            //Act
            Vector VectorC = VectorComplexMath.MultSkalVector(VectorA, Skalar);
            string Result = $"{VectorC.VectorX},{VectorC.VectorY},{VectorC.VectorZ}";

            //Assert
            Assert.AreEqual(Result, "4,4,4");
        }


        /// <summary>
        /// Tests calc of crossproduct of VectorMath
        /// </summary>
        [TestMethod]
        public void CrossProductVector_CalculateCrossProduct_ReturnsCrossProduct()
        {
            Vector VectorA = new Vector(2, 4, 1);
            Vector VectorB = new Vector(3, 5, 2);

            Vector VectorC = VectorComplexMath.CrossProductVector(VectorA, VectorB);
            string Result = $"{VectorC.VectorX},{VectorC.VectorY},{VectorC.VectorZ}";

            Assert.AreEqual(Result, "3,-1,-2");
        }


    }
}