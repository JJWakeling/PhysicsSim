using Model;
using ModelImplementation;
using Console;
using ConsoleImplementation;
using Controller;
using ControllerImplementation;

namespace PhysicsSim
{
    class Program
    {
        static void Main(string[] args)
        {
            IDensityModel model = new FakeDensityModel();
            IDensityCharacterMap characterMap = new FakeDensityCharacterMap();
            IScreen screen = new FixedSizeWindowsConsole(50, 50, characterMap);
            IRectangle viewBoundary = new Rectangle(0.0d, 0.0d, 50.0d, 50.0d);
            IObserver observer = new FixedRectangleObserver(screen, model, viewBoundary, 1000, 1.0d);

            observer.Run();
            System.Console.ReadLine();
        }
    }
}
