
namespace Model
{
    public interface IDensityModel
    {
        //TODO: refactor method signature using some new type so you don't have so many silly parameters
        double Density(double time, double minX, double minY, double maxX, double maxY);
    }

    public class FakeDensityModel : IDensityModel
    {
        

        public double Density(double time, double minX, double minY, double maxX, double maxY)
        {
            return 0.0d;
        }
    }
}
