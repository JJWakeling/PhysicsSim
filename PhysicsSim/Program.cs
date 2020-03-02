using Model;
using Console;
using ConsoleImplementation;
using Controller;

namespace PhysicsSim
{
    class Program
    {
        static void Main(string[] args)
        {
            IDensityModel model = new FakeDensityModel();
            IDensityCharacterMap characterMap = new FakeDensityCharacterMap();
            IScreen screen = new Screen(50, 50, characterMap);
            IObserver observer = new FakeObserver(100.0d, 100.0d, screen, model);
            observer.Run();
        }
    }
}
