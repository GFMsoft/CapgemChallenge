using VectorChallenge;

namespace VectorUnitTests
{

    /// <summary>
    /// TestClass for testing the creation of vectors
    /// </summary>
    [TestClass]
    public class VectorsCreationTest
    {

        /// <summary>
        /// Tests if creation of vector is correct.
        /// </summary>
        [TestMethod]
        public void Vector_CreateVector_ReturnsVectorCoords()
        {
            //Arrange and Act
            Vector testVector = new Vector(2, 2, 2);
            
            //Assert
            Assert.AreEqual(testVector.VectorX, 2);
            Assert.AreEqual(testVector.VectorY, 2);
            Assert.AreEqual(testVector.VectorZ, 2);
        }


    }
}
