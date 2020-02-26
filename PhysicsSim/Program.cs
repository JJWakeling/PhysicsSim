using Model;

namespace PhysicsSim
{
    class Program
    {
        static void Main(string[] args)
        {
            IDensityModel model = new FakeDensityModel();
            ConsoleOutput output = new ConsoleOutput(100, 100, model, -1, 1);
            output.Refresh(0);
        }
    }
}
