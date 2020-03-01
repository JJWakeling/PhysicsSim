
namespace Console
{
    public interface IDensityCharacterMap
    {
        char Map(double density);
    }

    public class FakeDensityCharacterMap : IDensityCharacterMap
    {
        public char Map(double density)
        {
            return '+';
        }
    }
}
