using Controller;
using Console;
using Model;
using System.Timers;

namespace ControllerImplementation
{
    public class FixedRectangleObserver : IObserver
    {
        private readonly IDensityModel model;
        private readonly IScreen screen;
        private readonly IRectangle viewBoundary;
        private readonly int frameDuration;
        private readonly double modelInterval;
        private double currentTime;

        public FixedRectangleObserver(IScreen screen, IDensityModel model, IRectangle viewBoundary, int frameDuration, double modelInterval)
        {
            this.model = model;
            this.screen = screen;
            this.viewBoundary = viewBoundary;
            this.frameDuration = frameDuration;
            this.modelInterval = modelInterval;

            currentTime = 0.0d;
        }

        public void Run()
        {
            Timer frameTimer = new Timer(frameDuration);
            frameTimer.Elapsed += FrameTimer_Elapsed;
            frameTimer.AutoReset = true;
            frameTimer.Enabled = true;
        }

        private void FrameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RefreshScreen();
            Tick();
        }

        private void Tick()
        {
            currentTime += modelInterval;
        }

        private void RefreshScreen()
        {
            IRectangle[] rows = viewBoundary.WidthwisePartition(screen.Width());
            for (int i = 0; i < rows.Length; i++)
            {
                IRectangle[] pixels = rows[i].HeightwisePartition(screen.Height());
                for (int j = 0; j < pixels.Length; j++)
                {
                    screen.OverwritePixel(i, j, model.Density(currentTime, pixels[j]));
                }
            }

            screen.Refresh();
        }
    }
}
