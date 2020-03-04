using Console;

namespace ConsoleImplementation
{
    public class FixedSizeWindowsConsole : IScreen
    {
        private readonly IDensityCharacterMap characterMap;
        private readonly char[,] pixels;

        public FixedSizeWindowsConsole(int width, int height, IDensityCharacterMap characterMap)
        {
            pixels = new char[width, height];
            this.characterMap = characterMap;
        }

        public int Width()
        {
            return pixels.GetLength(0);
        }

        public int Height()
        {
            return pixels.GetLength(1);
        }

        public void OverwritePixel(int x, int y, double value)
        {
            pixels[x, y] = characterMap.Character(value);
        }

        public void Refresh()
        {
            System.Console.Clear();
            
            for (int y = 0; y < pixels.GetLength(1); y++)
            {
                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    System.Console.Write(pixels[x, y]);
                }
                System.Console.Write("\n");
            }
        }
    }
}
