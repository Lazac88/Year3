using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InClassUnitTesting2017;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LargestValue_HighestFirst()
        {
            ArrayUtilities target = new ArrayUtilities();
            int[] highestFirst = new int[] { 9, 4, 7 };

            int actual = target.LargestValue(highestFirst);
            int expected = 9;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestValue_HighestLast()
        {
        }

        [TestMethod]
        public void LargestValue_HighestMiddle()
        {
        }

        [TestMethod]
        public void LargestValue_Repetition()
        {
        }

        [TestMethod]
        public void LargestValue_NegativeNumbers()
        {
        }
        
    }
}
