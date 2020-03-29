using NUnit.Framework;
using Model;

namespace ModelTest
{
    [TestFixture]
    public class TestFakePosition
    {
        private FakePosition position;
        private double[] coordinates;

        [SetUp]
        public void SetUp()
        {
            coordinates = new double[] { 42.0d, 33.3d };
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
            Assert.IsTrue(position.Equals(new FakePosition(new double[] { 42.0d, 33.3d })));
        }

        [Test]
        public void Test_Equals_with_IPosition_at_different_coordinates_returns_false()
        {
            Assert.IsFalse(position.Equals(new FakePosition(new double[] { 1.0d, 1.0d })));
        }

        [Test]
        public void Test_Equals_with_IPosition_of_greater_dimension_returns_false()
        {
            Assert.IsFalse(position.Equals(new FakePosition(new double[] { 42.0d, 33.3d, 4.0d })));
        }

        [Test]
        public void Test_Equals_with_IPosition_of_smaller_dimension_returns_false()
        {
            Assert.IsFalse(position.Equals(new FakePosition(new double[] { 42.0d })));
        }

        // TODO: check that using == and Assert.AreEqual also work here
    }
}
