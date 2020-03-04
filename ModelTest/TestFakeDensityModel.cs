using NUnit.Framework;
using Model;
using ModelImplementation;

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
            IRectangle rectangle = new Rectangle(0.0d, 1.0d, 0.0d, 1.0d);
            Assert.AreEqual(0.0d, model.Density(0.0d, rectangle));
        }
    }
}