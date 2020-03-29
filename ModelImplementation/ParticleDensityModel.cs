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
            double density = 0.0d;
            foreach (IParticle particle in particles)
            {
                if (boundingBox.Contains(particle.Position(time)))
                {
                    density += 1.0d;
                }
            }

            return density;
        }
    }
}
