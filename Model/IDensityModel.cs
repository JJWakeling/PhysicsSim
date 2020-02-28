
namespace Model
{
    public interface IDensityModel
    {
        //TODO: refactor method signature using some new type so you don't have so many silly parameters
        double[,] Densities(double time, double minX, double minY, double maxX, double maxY, int resolutionX, int resolutionY);
    }

    public class FakeDensityModel : IDensityModel
    {
        public int[,] Densities(int time, int minX, int minY, int maxX, int maxY, int resolutionX, int resolutionY)
        {
            return new int[maxY - minY, maxX - minX];
        }

        public double[,] Densities(double time, double minX, double minY, double maxX, double maxY, int resolutionX, int resolutionY)
        {
            return new double[resolutionY, resolutionX];
        }
    }
}
