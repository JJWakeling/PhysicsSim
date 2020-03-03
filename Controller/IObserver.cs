using Console;
using Model;

namespace Controller
{
    public interface IObserver
    {
        void Run();
    }

    public class FakeObserver : IObserver
    {
        private readonly double width, height;
        private readonly IDensityModel model;
        private readonly IScreen screen;

        public FakeObserver(double width, double height, IScreen screen, IDensityModel model)
        {
            this.width = width;
            this.height = height;
            this.model = model;
            this.screen = screen;
        }

        public void Run()
        {
            this.screen.Refresh(model, -width / 2, -height / 2, width / 2, height / 2, 0);
        }
    }
}
