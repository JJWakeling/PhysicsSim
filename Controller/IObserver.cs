
namespace Controller
{
    public interface IObserver
    {
        void Run();
    }

    public class FakeObserver : IObserver
    {
        private readonly double width, height;
        private readonly Model.IDensityModel model;
        private readonly Console.IScreen screen;

        public FakeObserver(double width, double height, Console.IScreen screen, Model.IDensityModel model)
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
