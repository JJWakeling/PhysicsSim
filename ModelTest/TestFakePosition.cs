using NUnit.Framework;
using Model;

namespace ModelImplementationTest
{
    [TestFixture]
    public class TestFakePosition
    {
        private FakePosition position;
        private double[] coordinates;

        [SetUp]
        public void SetUp()
        {
            coordinates = new double[] {42.0d, 33.3d};
            position = new FakePosition(coordinates);
        }

        [Test]
        public void Test_CanonicalCoordinates_returns_constructor_argument()
        {
            Assert.AreEqual(coordinates, position.CanonicalCoordinates());
        }

        [Test]
        public void Test_Equals_with_IPosition_at_same_coordinates_returns_true()
        {

        }
    }
}
