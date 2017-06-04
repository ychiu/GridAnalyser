using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridAnalyser;

namespace GridAnalyserTests
{
    [TestClass]
    public class CombinationAnalyserTests
    {
        /**
         * Scenarios : 
         * I (adjacent ints) = 3
         * M (No of columns) = 3
         * N (No of rows) = 1
         * 
         * I:3; M:3; N:1 ==> X = 1
         * I:3; M:4; N:1 ==> X = 2
         * I:3; M:5; N:1 ==> X = 3
         * I:3; M:5; N:1 ==> X = 4
         * 
         * Hypothesis : combinations follow formula
         * X = (M-I) + 1
         */

        [TestMethod]
        public void HorizontalCombinations_3x1GridWith3AdjacentInts_Returns1()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 1;
            int result = analyser.HorizontalCombinations(3, 1);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void HorizontalCombinations_4x1GridWith3AdjacentInts_Returns2()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 2;
            int result = analyser.HorizontalCombinations(4, 1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HorizontalCombinations_5x1GridWith3AdjacentInts_Returns3()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 3;
            int result = analyser.HorizontalCombinations(5, 1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HorizontalCombinations_6x1GridWith3AdjacentInts_Returns4()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 4;
            int result = analyser.HorizontalCombinations(6, 1);
            Assert.AreEqual(expected, result);
        }


    }
}
