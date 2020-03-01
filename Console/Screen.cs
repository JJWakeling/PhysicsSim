using Model;

namespace Console
{
    public class Screen : IScreen
    {
        private readonly int width, height;
        private readonly IDensityCharacterMap characterMap;

        public Screen(int width, int height, IDensityCharacterMap characterMap)
        {
            this.width = width;
            this.height = height;
            this.characterMap = characterMap;
        }

        public void Refresh(IDensityModel model, double minX, double minY, double maxX, double maxY, double time)
        {
            System.Console.Clear();

            double[,] densities = model.Densities(time, minX, minY, maxX, maxY, width, height);
            for (int b = 0; b < densities.GetLength(1); b++)
            {
                for (int a = 0; a < densities.GetLength(0); a++)
                {
                    System.Console.Write(characterMap.Map(densities[a, b]));
                }
                System.Console.Write("\n");
            }
        }
    }
}
