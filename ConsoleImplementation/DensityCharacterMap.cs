using Console;

namespace ConsoleImplementation
{
    class DensityCharacterMap : IDensityCharacterMap
    {
        private readonly double[] thresholds;
        private readonly char[] outputs;

        public DensityCharacterMap(double[] thresholds, char[] outputs)
        {

        }

        public char Character(double density)
        {
            throw new System.NotImplementedException();
        }
    }
}
