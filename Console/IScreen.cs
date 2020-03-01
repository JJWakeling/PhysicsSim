using Model;

namespace Console
{
    public interface IScreen
    {
        void Refresh(IDensityModel model, double minX, double minY, double maxX, double maxY, double time);
    }
}
