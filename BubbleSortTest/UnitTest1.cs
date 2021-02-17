using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;
using System;
using System.Linq;

namespace BubbleSortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] test = { 3, 2, 1 };
            int[] sorted = { 1, 2, 3 };
            Assert.IsTrue(SortArrays.bubbleSort(test).SequenceEqual(sorted));
        }
    }
}
