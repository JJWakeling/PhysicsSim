using NUnit.Framework;
using Console;

namespace ConsoleTest
{
    [TestFixture]
    public class TestFakeDensityCharacterMap
    {
        private FakeDensityCharacterMap map;

        [SetUp]
        public void Setup()
        {
            map = new FakeDensityCharacterMap();
        }

        [Test]
        public void Test_Character_returns_plus_sign()
        {
            Assert.AreEqual('+', map.Character(42.53d));
        }
    }
}