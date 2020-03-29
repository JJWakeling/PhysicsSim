using Model;

namespace ModelImplementation
{
    public class StaticParticle : IParticle
    {
        private readonly IPosition position;

        public StaticParticle(IPosition position)
        {
            this.position = position;
        }

        public IPosition Position(double time)
        {
            return position;
        }
    }
}
