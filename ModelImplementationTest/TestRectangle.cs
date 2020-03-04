using NUnit.Framework;
using ModelImplementation;

namespace Tests
{
    [TestFixture]
    public class TestRectangle
    {
        private Rectangle rectangle;

        [SetUp]
        public void Setup()
        {
            rectangle = new Rectangle(0.0d, 1.0d, 0.0d, 1.0d);
        }

        [Test]
        public void Test_WidthwisePartition_returns_array_of_length_specified()
        {
            Assert.AreEqual(5, rectangle.WidthwisePartition(5).Length);
        }

        [Test]
        public void Test_HeightwisePartition_returns_array_of_length_specified()
        {
            Assert.AreEqual(8, rectangle.HeightwisePartition(8).Length);
        }
    }
}