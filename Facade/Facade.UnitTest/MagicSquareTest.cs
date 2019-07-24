using ConsoleApp3;
using NUnit.Framework;

namespace Tests
{
    [TestFixture()]
    public class MagicSquareTest
    {
        private Verifier magicSquareVerifier;
        private MagicSquareGenerator magicSquareGenerator;

        [SetUp]
        public void Setup()
        {
            magicSquareVerifier = new Verifier();
            magicSquareGenerator = new MagicSquareGenerator();
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void When_MagicSquareIsValid_Expected_true(int size)
        {
            var square = magicSquareGenerator.Generate(size);

            Assert.IsTrue(magicSquareVerifier.Verify(square),
              "Verification failed: this is not a magic square");
        }
    }
}