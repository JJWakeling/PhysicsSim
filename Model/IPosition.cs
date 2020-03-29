
namespace Model
{
    public interface IPosition
    {
        double[] CanonicalCoordinates();
        bool Equals(IPosition other);
        // TODO: make sure to overload == operator too and check what GetHashCode() does
    }

    public class FakePosition : IPosition
    {
        private readonly double[] coordinates;

        public FakePosition(double[] coordinates)
        {
            this.coordinates = coordinates;
        }

        public double[] CanonicalCoordinates()
        {
            return coordinates;
        }

        public bool Equals(IPosition other)
        {
            double[] otherCoordinates = other.CanonicalCoordinates();
            if (otherCoordinates.Length != coordinates.Length)
            {
                return false;
            }

            return CoordinatesMatch(otherCoordinates);
        }

        private bool CoordinatesMatch(double[] otherCoordinates)
        {
            bool match = true;
            for (int i = 0; i < coordinates.Length; i++)
            {
                match = coordinates[i] == otherCoordinates[i];
            }

            return match;
        }
    }
}
