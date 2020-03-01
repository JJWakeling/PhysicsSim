using Model;
using Console;

namespace PhysicsSim
{
    class Program
    {
        static void Main(string[] args)
        {
            IDensityModel model = new FakeDensityModel();
            IDensityCharacterMap characterMap = new FakeDensityCharacterMap();
            IScreen screen = new Screen(50, 50, characterMap);
            ConsoleOutput output = new ConsoleOutput(100.0d, 100.0d, screen, model);
            output.Refresh(0);
        }
    }
}
