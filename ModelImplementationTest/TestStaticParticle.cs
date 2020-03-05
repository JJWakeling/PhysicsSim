using NUnit.Framework;
using ModelImplementation;
using Model;

namespace ModelImplementationTest
{
    [TestFixture]
    public class TestStaticParticle
    {
        private IPosition position;
        private StaticParticle particle;

        [SetUp]
        public void SetUp()
        {
            position = new FakePosition(new double[] { 42.0d, 33.3d });
            particle = new StaticParticle(position);
        }

        [Test]
        public void Test_Position_returns_equivalent_IPosition_to_constructor_argument()
        {

        }
    }
}
