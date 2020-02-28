using NUnit.Framework;
using Model;

namespace Tests
{
    [TestFixture]
    public class TestFakeDensityModel
    {
        private FakeDensityModel model;

        // Arrange
        [SetUp]
        public void Setup()
        {
            this.model = new FakeDensityModel();
        }

        [Test]
        public void Test_Densities_returns_double_array_with_GetLength0_returns_resolutionY()
        {
            // Act
            double[,] densities = model.Densities(0.0d, 0.0d, 0.0d, 1.0d, 1.0d, 5, 42);

            // Assert
            Assert.AreEqual(42, densities.GetLength(0));
        }
    }
}