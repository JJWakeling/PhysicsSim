using Model;

namespace Console
{
    /* TODO: this class needs:
     * splitting up so tolerances are dealt with by their own class
     */ 
     // N.b. because of use of System.Console.Clear, this class will only work for Windows-style terminals
    public class ConsoleOutput
    {
        private readonly double width, height, lowTolerance, highTolerance;
        private readonly int screenWidth, screenHeight;
        private readonly IDensityModel model;

        public ConsoleOutput(double width, double height, int screenWidth, int screenHeight, IDensityModel model, double lowTolerance, double highTolerance)
        {
            this.width = width;
            this.height = height;
            this.model = model;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            this.lowTolerance = lowTolerance;
            this.highTolerance = highTolerance;
        }

        public void Refresh(double time)
        {
            System.Console.Clear();
            double[,] densities = model.Densities(time, -width/2, -height/2, width/2, height/2, screenWidth, screenHeight);
            for (int b = 0; b < densities.GetLength(0); b++)
            {
                for (int a = 0; a < densities.GetLength(1); a++)
                {
                    double cell = densities[a, b];
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
