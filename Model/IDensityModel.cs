
namespace Model
{
    public interface IDensityModel
    {
        //TODO: refactor method signature using some new type so you don't have so many silly parameters
        int[,] Densities(int time, int minX, int minY, int maxX, int maxY, int resolutionX, int resolutionY);
    }

    public class FakeDensityModel : IDensityModel
    {
        public int[,] Densities(int time, int minX, int minY, int maxX, int maxY, int resolutionX, int resolutionY)
        {
            return new int[maxY - minY, maxX - minX];
        }
    }
}
