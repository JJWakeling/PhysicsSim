using NUnit.Framework;
using Model;

namespace Tests
{
    [TestFixture]
    public class TestFakeDensityModel
    {
        private FakeDensityModel model;
        
        [SetUp]
        public void Setup()
        {
            model = new FakeDensityModel();
        }

        [Test]
        public void Test_Density_returns_zero()
        {
            Assert.AreEqual(0.0d, model.Density(0, 0.0d, 0.0d, 1.0d, 1.0d));
        }
    }
}