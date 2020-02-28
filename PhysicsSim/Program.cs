using Model;
using Console;

namespace PhysicsSim
{
    class Program
    {
        static void Main(string[] args)
        {
            IDensityModel model = new FakeDensityModel();
            ConsoleOutput output = new ConsoleOutput(100.0d, 100.0d, 100, 100, model, -1.0d, 1.0d);
            output.Refresh(0);
        }
    }
}
