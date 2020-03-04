
namespace Console
{
    public interface IScreen
    {
        int Width();
        int Height();
        void OverwritePixel(int x, int y, double value);
        void Refresh();
    }
}
