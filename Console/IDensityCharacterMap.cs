
namespace Console
{
    public interface IDensityCharacterMap
    {
        char Character(double density);
    }

    public class FakeDensityCharacterMap : IDensityCharacterMap
    {
        public char Character(double density)
        {
            return '+';
        }
    }
}
