using NUnit.Framework;
using Console;
using ConsoleImplementation;

namespace Tests
{
    [TestFixture]
    public class TestFixedSizeWindowsConsole
    {
        private FixedSizeWindowsConsole console;

        [SetUp]
        public void Setup()
        {
            IDensityCharacterMap map = new FakeDensityCharacterMap();
            console = new FixedSizeWindowsConsole(40, 20, map);
        }

        [Test]
        public void Test_Width_returns_value_set_at_constructor()
        {
            Assert.AreEqual(40, console.Width());
        }

        [Test]
        public void Test_Height_returns_value_set_at_constructor()
        {
            Assert.AreEqual(20, console.Height());
        }

        // TODO: write test to check OverwritePixel throws an error if you try to write out of bounds
    }
}