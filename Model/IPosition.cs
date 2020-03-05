
namespace Model
{
    public interface IPosition
    {
        double CanonicalCoordinates();
        bool Equals(IPosition other);
        // TODO: make sure to overload == operator too and check what GetHashCode() does
    }

    public class FakePosition : IPosition
    {
        public FakePosition(double[] coordinates)
        {

        }

        public double CanonicalCoordinates()
        {
            throw new System.NotImplementedException();
        }

        public bool Equals(IPosition other)
        {
            throw new System.NotImplementedException();
        }
    }
}
