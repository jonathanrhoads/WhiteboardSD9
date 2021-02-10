using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;

namespace PrimeNumberTest
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(7));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(21));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(8));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(200));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(51));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(17));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(1));
            Assert.AreEqual(true, Primes.PrimeNumbers.IsPrime(0));
        }
    }
}
