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
            //Arrange
            Vector testVector = new Vector(2, 2, 2);

            //Act
            string result = "";
            result = $"{testVector.VectorX},{testVector.VectorY},{testVector.VectorZ}";

            //Assert
            Assert.AreEqual(result, "2,2,2");
        }


    }
}
