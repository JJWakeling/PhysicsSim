using NUnit.Framework;
using ModelImplementation;
using Model;

namespace ModelImplementationTest
{
    [TestFixture]
    public class TestParticleDensityModel
    {
        private ParticleDensityModel model;

        [SetUp]
        public void SetUp()
        {
            IPosition position1 = new FakePosition(new double[] { 12.0d, 5.3d });
            IParticle particle1 = new StaticParticle(position1);
            IPosition position2 = new FakePosition(new double[] { 12.0d, 8.1d });
            IParticle particle2 = new StaticParticle(position2);

            model = new ParticleDensityModel(new IParticle[] { particle1, particle2 });
        }

        [Test]
        public void Test_Density_with_rectangle_not_containing_particle_returns_zero()
        {

        }

        [Test]
        public void Test_Density_with_rectangle_containing_single_particle_returns_one()
        {

        }

        [Test]
        public void Test_Density_with_rectangle_containing_two_particles_returns_two()
        {

        }
    }
}
