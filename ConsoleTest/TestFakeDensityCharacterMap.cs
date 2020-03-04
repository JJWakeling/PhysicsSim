using NUnit.Framework;
using Console;

namespace Tests
{
    [TestFixture]
    public class TestFakeDensityCharacterMap
    {
        private FakeDensityCharacterMap map;

        [SetUp]
        public void Setup()
        {
            this.map = new FakeDensityCharacterMap();
        }

        [Test]
        public void Test_Character_returns_plus_sign()
        {
            Assert.AreEqual('+', map.Character(42.53d));
        }
    }
}