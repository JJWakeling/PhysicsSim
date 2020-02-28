using Model;

namespace Console
{
    /* TODO: this class needs:
     * moving into a project just for console displays
     * splitting up so tolerances are dealt with by their own class
     */ 
     // N.b. because of use of System.Console.Clear, this class will only work for Windows-style terminals
    public class ConsoleOutput
    {
        private readonly int width, height, lowTolerance, highTolerance;
        private readonly IDensityModel model;

        public ConsoleOutput(int width, int height, IDensityModel model, int lowTolerance, int highTolerance)
        {
            this.width = width;
            this.height = height;
            this.model = model;
            this.lowTolerance = lowTolerance;
            this.highTolerance = highTolerance;
        }

        public void Refresh(int time)
        {
            System.Console.Clear();
            int[,] densities = model.Densities(time, 0, 0, width, height, width, height);
            for (int b = 0; b < densities.GetLength(0); b++)
            {
                for (int a = 0; a < densities.GetLength(1); a++)
                {
                    int cell = densities[a, b];
                    if (cell < this.lowTolerance)
                    {
                        System.Console.Write(" ");
                    }
                    else if (cell < this.highTolerance)
                    {
                        System.Console.Write("+");
                    }
                    else
                    {
                        System.Console.Write("#");
                    }
                }
                System.Console.Write("\n");
            }
        }
    }
}
