using Controller;
using Console;
using Model;

namespace ControllerImplementation
{
    public class FixedRectangleObserver : IObserver
    {
        private readonly IDensityModel model;
        private readonly IScreen screen;
        private readonly IRectangle viewBoundary;

        public FixedRectangleObserver(IScreen screen, IDensityModel model, IRectangle viewBoundary)
        {
            this.model = model;
            this.screen = screen;
            this.viewBoundary = viewBoundary;
        }

        public void Run()
        {
            IRectangle[] rows = viewBoundary.WidthwisePartition(screen.Width());
            for (int i = 0; i < rows.Length; i++)
            {
                IRectangle[] pixels = rows[i].HeightwisePartition(screen.Height());
                for (int j = 0; j < pixels.Length; j++)
                {
                    screen.OverwritePixel(i, j, model.Density(0, pixels[j]));
                }
            }

            screen.Refresh();
        }
    }
}
