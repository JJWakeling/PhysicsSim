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
        public void Test_Densities_returns_double_array_with_GetLength0_returns_resolutionX()
        {
            // Act
            double[,] densities = model.Densities(0.0d, 0.0d, 0.0d, 1.0d, 1.0d, 5, 42);

            // Assert
            Assert.AreEqual(5, densities.GetLength(0));
        }

        [Test]
        public void Test_Densities_returns_double_array_with_GetLength1_returns_resolutionY()
        {
            // Act
            double[,] densities = model.Densities(0.0d, 0.0d, 0.0d, 1.0d, 1.0d, 5, 42);

            // Assert
            Assert.AreEqual(42, densities.GetLength(1));
        }

        [Test]
        public void Test_Densities_returns_double_array_with_all_zeroes()
        {
            // Act
            double[,] densities = model.Densities(0.0d, 0.0d, 0.0d, 1.0d, 1.0d, 2, 3);

            // Assert
            Assert.Multiple(() =>
            {
                for (int x = 0; x < densities.GetLength(0); x++)
                {
                    for (int y = 0; y < densities.GetLength(1); y++)
                    {
                        Assert.AreEqual(0.0d, densities[x, y]);
                    }
                }
            });
        }
    }
}