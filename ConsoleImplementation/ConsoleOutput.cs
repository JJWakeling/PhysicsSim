using Model;
using Console;

namespace ConsoleImplementation
{
    public class ConsoleOutput
    {
        private readonly double width, height;
        private readonly IDensityModel model;
        private readonly IScreen screen;

        public ConsoleOutput(double width, double height, IScreen screen, IDensityModel model)
        {
            this.width = width;
            this.height = height;
            this.model = model;
            this.screen = screen;
        }

        public void Refresh(double time)
        {
            this.screen.Refresh(model, -width / 2, -height / 2, width / 2, height / 2, time);
        }
    }
}
