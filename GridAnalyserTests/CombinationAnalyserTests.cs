using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridAnalyser;

namespace GridAnalyserTests
{
    [TestClass]
    public class CombinationAnalyserTests
    {
        [TestMethod]
        public void HorizontalCombinations_3x1GridWith3AdjacentInts_Returns1()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            int expected = 1;
            int result = analyser.HorizontalCombinations(3, 1);
            Assert.AreEqual(expected, result);

        }
    }
}
