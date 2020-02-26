using System;
using Model;

namespace PhysicsSim
{
    /* TODO: this class needs:
     * moving into a project just for console displays
     * splitting up so tolerances are dealt with by their own class
     */ 
    class ConsoleOutput
    {
        private readonly int width, height, lowTolerance, highTolerance;
        private readonly IDensityModel model;

        public ConsoleOutput(int width, int height, IDensityModel model, int lowTolerance, int highTolerance)
        {
            this.width = width;
            this.height = height;
            this.model = model;
            this.lowTolerance = lowTolerance;
        }

        public void Refresh(int time)
        {
            Console.Clear();
            int[,] densities = model.Densities(time, 0, 0, width, height, width, height);
            for (int b = 0; b < densities.GetLength(0); b++)
            {
                for (int a = 0; a < densities.GetLength(1); a++)
                {
                    int cell = densities[a, b];
                    if (cell < this.lowTolerance)
                    {
                        Console.Write(" ");
                    }
                    else if (cell < this.highTolerance)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
