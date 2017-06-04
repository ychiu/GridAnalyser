using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridAnalyser;

namespace GridAnalyserTests
{
    [TestClass]
    public class CombinationAnalyserTests
    {
        #region HorizontalCombinations Tests

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

        // Test methods for grids greater than 1 row
        [TestMethod]
        public void HorizontalCombinations_6x2GridWith3AdjacentInts_Returns8()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 8;
            int result = analyser.HorizontalCombinations(6, 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HorizontalCombinations_5x2GridWith3AdjacentInts_Returns6()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 6;
            int result = analyser.HorizontalCombinations(5, 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HorizontalCombinations_4x2GridWith3AdjacentInts_Returns4()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 4;
            int result = analyser.HorizontalCombinations(4, 2);
            Assert.AreEqual(expected, result);
        }
        #endregion


        #region LRDiagonalCombinations Tests

        /**
         * Diagonal Tests
         * Scenarios 
         * 3 x 3 grid (Adjacent Integers = 3)
         * Left to Right (LR) yields = 1 combination
         * Right to Left (RL) yeilds = 1 combination
         * Total = 2
         */

        [TestMethod]
        public void LRDiagonalCombinations_3x3GridWith3AdjacentInts_Returns1()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 1;
            int result = analyser.LRDiagonalCombinations(3, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LRDiagonalCombinations_4x4GridWith3AdjacentInts_Returns4()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 4;
            int result = analyser.LRDiagonalCombinations(4, 4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LRDiagonalCombinations_5x5GridWith3AdjacentInts_Returns8()
        {
            CombinationAnalyser analyser = new CombinationAnalyser();
            analyser.adjacentIntegers = 3;
            int expected = 8;
            int result = analyser.LRDiagonalCombinations(5, 5);
            Assert.AreEqual(expected, result);
        }
        #endregion


    }
}
