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
            
            //Assert
            Assert.AreEqual(VectorC.VectorX, 4);
            Assert.AreEqual(VectorC.VectorY, 4);
            Assert.AreEqual(VectorC.VectorZ, 4);
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
                        
            Assert.AreEqual(VectorC.VectorX, 3);
            Assert.AreEqual(VectorC.VectorY, -1);
            Assert.AreEqual(VectorC.VectorZ, -2);
        }


    }
}