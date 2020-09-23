using NUnit.Framework;

using PrimeNumbers.Controllers;

namespace PrimeNumbers.Tests
{
    /// <summary>
    /// Tests for the IsPrimeNumber controller functionionality
    ///</summary>
    public class IsPrimeNumberTests
    {
        /// <summary>
        /// Test to see if all numbers on a list of known small prime numbers are shown as prime
        ///</summary>
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(17)]
        [TestCase(19)]
        [TestCase(23)]
        public void IsPrime_CheckSmallNumbers_Prime(int comparator)
        {
            Assert.IsTrue(DoIsPrimeCheckOnNumber(comparator), "Failed for {0}", comparator);
        }

        /// <summary>
        /// Test to see if all numbers on a list of known small non-prime numbers are shown as non-prime
        ///</summary>
        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        public void IsPrime_CheckSmallNumbers_NotPrime(int comparator)
        {
            Assert.IsFalse(DoIsPrimeCheckOnNumber(comparator), "Failed for {0}", comparator);
        }

        /// <summary>
        /// Test to see if all numbers on a list of known large prime numbers are shown as prime
        ///</summary>
        [Test]
        [TestCase(2609)]
        [TestCase(3631)]
        [TestCase(5147)]
        [TestCase(10301)]
        [TestCase(10979)]
        [TestCase(45763)]
        [TestCase(100673)]
        [TestCase(401069)]
        [TestCase(901171)]
        public void IsPrime_CheckLargeNumbers_Prime(int comparator)
        {
            Assert.IsTrue(DoIsPrimeCheckOnNumber(comparator), "Failed for {0}", comparator);
        }

        /// <summary>
        /// Test to see if all numbers on a list of known large non-prime numbers are shown as non-prime
        ///</summary>
        [Test]
        [TestCase(2610)]
        [TestCase(8723)]
        [TestCase(10098)]
        [TestCase(10777)]
        [TestCase(20345)]
        [TestCase(34986)]
        [TestCase(100552)]
        [TestCase(300912)]
        [TestCase(769986)]
        public void IsPrime_CheckLargeNumbers_NotPrime(int comparator)
        {
            Assert.IsFalse(DoIsPrimeCheckOnNumber(comparator), "Failed for {0}", comparator);
        }

        /// <summary>
        /// Test to see if all numbers on a list of negative numbers are shown as non-prime
        ///</summary>
        [Test]
        [TestCase(-3)]
        [TestCase(-40)]
        [TestCase(-99)]
        [TestCase(-4002)]
        [TestCase(-8910)]
        [TestCase(-20872)]
        [TestCase(-55777)]
        [TestCase(-380981)]
        [TestCase(-981212)]
        public void IsPrime_CheckNegativeNumbers_NotPrime(int comparator)
        {
            Assert.IsFalse(DoIsPrimeCheckOnNumber(comparator), "Failed for {0}", comparator);
        }

        /// <summary>
        /// Test to see if zero is shown as non-prime
        ///</summary>
        [Test]
        public void IsPrime_CheckZero_NotPrime()
        {
            Assert.IsFalse(DoIsPrimeCheckOnNumber(0), "Failed for {0}", 0);
        }

        /// <summary>
        /// Test to see if one is shown as non-prime
        ///</summary>
        [Test]
        public void IsPrime_CheckOne_NotPrime()
        {
            Assert.IsFalse(DoIsPrimeCheckOnNumber(1), "Failed for {0}", 1);
        }

        private bool DoIsPrimeCheckOnNumber(int comparator)
        {
            IsPrimeNumberController controller = new IsPrimeNumberController();

            return controller.CheckIsPrime(comparator);
        }
    }
}
