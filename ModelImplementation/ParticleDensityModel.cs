using Model;

namespace ModelImplementation
{
    public class ParticleDensityModel : IDensityModel
    {
        private readonly IParticle[] particles;

        public ParticleDensityModel(IParticle[] particles)
        {
            this.particles = particles;
        }

        public double Density(double time, IRectangle boundingBox)
        {
            throw new System.NotImplementedException();
        }
    }
}
