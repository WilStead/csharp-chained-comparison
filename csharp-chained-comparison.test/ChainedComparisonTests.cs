using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chain.test
{
    [TestClass]
    public class ChainedComparisonTests
    {
        [TestMethod]
        public void ShouldAllowChainingComparisons()
        {
            int x = 1;
            int y = 2;
            int z = 0;
            Assert.IsTrue((ChainComparator)x < y > z);

            Assert.IsTrue((ChainComparator)(short)1 < (short)2 < (short)3);

            short s = 1;
            int boxedS = s;
            Assert.IsTrue((ChainComparator)boxedS < 2);

            Assert.IsTrue((ChainComparator)(decimal)1.1 <= (decimal)1.1 == (decimal)1.1 != (decimal)5.4);

            Assert.IsTrue((ChainComparator)'a' < 'b' < 'c');
            Assert.IsFalse((ChainComparator)'z' < 'b' < 'c');

            Assert.IsTrue((ChainComparator)"Hello" < "World" > "!" == "!");
        }

        [TestMethod]
        public void ShouldThrowExceptionOnTypeMismatch()
        {
            Assert.ThrowsException<ArgumentException>(() => { var x = (ChainComparator)(short)1 < 2 < (double)3 == 'a'; });
        }
    }
}
