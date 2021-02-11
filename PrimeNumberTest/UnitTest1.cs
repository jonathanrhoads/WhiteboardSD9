using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;

namespace PrimeNumberTest
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, PrimeNumbers.IsPrime(7));
        }   
        [TestMethod]
        public void TestMethod21()
        {
            Assert.AreEqual(true, PrimeNumbers.IsPrime(21));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, PrimeNumbers.IsPrime(8));
        }
        [TestMethod]
        public void TestMethod51()
        {
            Assert.AreEqual(true, PrimeNumbers.IsPrime(51));
        }
        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(false, PrimeNumbers.IsPrime(0));
        }
    }

    //public class SumOfPrimesTest
    //{
    //    [TestMethod]
    //    public void TestMethod80()
    //    {
    //        Assert.AreEqual()
    //    }
    }
}
