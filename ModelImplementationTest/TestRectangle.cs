using NUnit.Framework;
using ModelImplementation;
using Model;

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

        [Test]
        public void Test_Contains_returns_true_for_point_inside_rectangle()
        {
            Assert.IsTrue(rectangle.Contains(new FakePosition(new double[] { 0.5d, 0.5d })));
        }

        [Test]
        public void Test_Contains_returns_false_for_point_outside_rectangle()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 2.0d, 2.0d })));
        }

        [Test]
        public void Test_Contains_returns_true_for_point_on_canonical_left_edge()
        {
            Assert.IsTrue(rectangle.Contains(new FakePosition(new double[] { 0.0d, 0.5d })));
        }

        [Test]
        public void Test_Contains_returns_true_for_point_on_canonical_top_edge()
        {
            Assert.IsTrue(rectangle.Contains(new FakePosition(new double[] { 0.5d, 0.0d })));
        }

        [Test]
        public void Test_Contains_returns_false_for_point_on_canonical_right_edge()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 1.0d, 0.5d })));
        }

        [Test]
        public void Test_Contains_returns_false_for_point_on_canonical_bottom_edge()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 0.5d, 1.0d })));
        }

        [Test]
        public void Test_Contains_returns_true_for_canonical_top_left_corner()
        {
            Assert.IsTrue(rectangle.Contains(new FakePosition(new double[] { 0.0d, 0.0d })));
        }

        [Test]
        public void Test_Contains_returns_false_for_canonical_top_right_corner()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 1.0d, 0.0d })));
        }

        [Test]
        public void Test_Contains_returns_false_for_canonical_bottom_left_corner()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 0.0d, 1.0d })));
        }
        
        [Test]
        public void Test_Contains_returns_false_for_canonical_bottom_right_corner()
        {
            Assert.IsFalse(rectangle.Contains(new FakePosition(new double[] { 1.0d, 1.0d })));
        }
    }
}