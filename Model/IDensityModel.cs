
namespace Model
{
    public interface IDensityModel
    {
        double Density(double time, IRectangle boundingBox);
    }

    public class FakeDensityModel : IDensityModel
    {

        public double Density(double time, IRectangle boundingBox)
        {
            return 0.0d;
        }
    }
}
