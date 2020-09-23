using NUnit.Framework;

using PrimeNumbers.Controllers;

namespace PrimeNumbers.Tests
{
    /// <summary>
    /// Tests for the NextPrimeNumber controller functionionality
    ///</summary>
    public class NextPrimeNumberTests
    {
        /// <summary>
        /// Test to see if the next prime returned for all numbers on a list of small numbers match the expected values
        ///</summary>
        [Test]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(16, 17)]
        [TestCase(17, 17)]
        [TestCase(54, 59)]
        [TestCase(68, 71)]
        [TestCase(80, 83)]
        [TestCase(100, 101)]
        public void NextPrime_CheckSmallNumbers_ExpectedValues(int baseValue, int expectedValue)
        {
            int nextPrime = RetrieveNextPrimeForNumber(baseValue);
            Assert.IsTrue(nextPrime == expectedValue, "Failed for {0} - expected {1}, result was {2}", baseValue, expectedValue, nextPrime);
        }

        /// <summary>
        /// Test to see if the next prime returned for all numbers on a list of large numbers match the expected values
        ///</summary>
        [Test]
        [TestCase(3350, 3359)]
        [TestCase(4722, 4723)]
        [TestCase(5660, 5669)]
        [TestCase(9153, 9157)]
        [TestCase(9969, 9973)]
        [TestCase(101099, 101107)]
        [TestCase(400627, 400643)]
        [TestCase(801004, 801007)]
        public void NextPrime_CheckLargeNumbers_ExpectedValues(int baseValue, int expectedValue)
        {
            int nextPrime = RetrieveNextPrimeForNumber(baseValue);
            Assert.IsTrue(nextPrime == expectedValue, "Failed for {0} - expected {1}, result was {2}", baseValue, expectedValue, nextPrime);
        }

        /// <summary>
        /// Test to see if the next prime returned for all numbers on a list of negative numbers match the expected value of 2
        ///</summary>
        [Test]
        [TestCase(-1)]
        [TestCase(-30)]
        [TestCase(-1249)]
        [TestCase(-4329)]
        [TestCase(-9821)]
        [TestCase(-22339)]
        [TestCase(-59912)]
        [TestCase(-799922)]
        public void NextPrime_CheckNegativeNumbers_ExpectedValue(int baseValue)
        {
            int nextPrime = RetrieveNextPrimeForNumber(baseValue);
            Assert.IsTrue(nextPrime == 2, "Failed for {0} - expected {1}, result was {2}", baseValue, 2, nextPrime);
        }

        /// <summary>
        /// Test to see if the next prime returned for 0 is 2
        ///</summary>
        [Test]
        public void NextPrime_CheckZero_ExpectedValue()
        {
            int nextPrime = RetrieveNextPrimeForNumber(0);
            Assert.IsTrue(nextPrime == 2, "Failed for {0} - expected {1}, result was {2}", 0, 2, nextPrime);
        }

        /// <summary>
        /// Test to see if the next prime returned for 1 is 2
        ///</summary>
        [Test]
        public void NextPrime_CheckOne_ExpectedValue()
        {
            int nextPrime = RetrieveNextPrimeForNumber(1);
            Assert.IsTrue(nextPrime == 2, "Failed for {0} - expected {1}, result was {2}", 1, 2, nextPrime);
        }

        private int RetrieveNextPrimeForNumber(int baseValue)
        {
            NextPrimeNumberController controller = new NextPrimeNumberController();

            return controller.GetNextPrime(baseValue);
        }
    }
}
