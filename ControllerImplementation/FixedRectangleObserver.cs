using Controller;
using Console;
using Model;

namespace ControllerImplementation
{
    public class FixedRectangleObserver : IObserver
    {
        private readonly IDensityModel model;
        private readonly IScreen screen;
        private readonly double minX, maxX, minY, maxY;

        public FixedRectangleObserver(IScreen screen, IDensityModel model, double minX, double maxX, double minY, double maxY)
        {
            this.model = model;
            this.screen = screen;
            this.minX = minX;
            this.maxX = maxX;
            this.minY = minY;
            this.maxY = maxY;
        }

        public void Run()
        {
            int screenWidth = screen.Width();
            int screenHeight = screen.Height();

            double pixelWidth = (maxX - minX) / (double)screenWidth;
            double pixelHeight = (maxY - minY) / (double)screenHeight;
            for (int i = 0; i < screenWidth; i++)
            {
                for (int j = 0; j < screenHeight; j++)
                {
                    screen.OverwritePixel(i, j, model.Density(0, i * pixelWidth, j * pixelHeight, (i + 1) * pixelWidth, (j + 1) * pixelHeight));
                }
            }

            screen.Refresh();
        }
    }
}
