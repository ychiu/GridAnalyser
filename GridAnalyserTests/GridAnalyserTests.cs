using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridAnalyserLibrary;

namespace GridAnalyserTests
{
    [TestClass]
    public class GridAnalyserUnitTest
    {
        // Test Question Example Grid
        int [,] QuExampleGrid = {
            {8,2,22,97,38,15,0,40,0,75},
            {49,49,99,40,17,81,18,57,60,87},
            {81,49,31,73,55,79,14,29,93,71},
            {52,70,95,23,4,60,11,42,69,24},
            {22,31,16,71,51,67,63,89,41,92},
            {24,47,32,60,99,3,45,2,44,75},
            {32,98,81,28,64,23,67,10,26,38},
            {67,26,20,68,2,62,12,20,95,63},
            {24,55,58,5,66,73,99,26,97,17},
            {21,36,23,9,75,0,76,44,20,45}
        };

        #region findRowProduct Test

        [TestMethod]
        public void findRowProduct_FirstRowFirstSection_Returns55290()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.FindRowProduct(0, 0, 3);
            var expected = 8 * 2 * 22;
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void findRowProduct_FirstRowSecondSection_Returns352()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.FindRowProduct(0, 3, 3);
            var expected = 97 * 38 * 15;
            Assert.AreEqual(expected, product);
        }
        #endregion

        #region AnalyseRow Tests

        [TestMethod]
        public void AnalyseRow_FirstRow_Returns81092()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 81092; // (22,97,38)
            var result = analyser.AnalyseRow(0);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AnalyseRow_LastRow_Returns66880()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 66880; // (76,44,20)
            var result = analyser.AnalyseRow(9);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region AnalyseRows Test

        [TestMethod]
        public void AnalyseRows_FullQuExampleGrid_ReturnsX()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 476982; // Unverified
            var result = analyser.AnalyseRows();
            Assert.AreEqual(expected, result);
        }

        #endregion

        #region findColumnProduct
        [TestMethod]
        public void findColumnProduct_FirstColumnFirstSection_Returns31752()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.FindColumnProduct(0, 0, 3);
            var expected = 8 * 49 * 81;
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void findColumnProduct_FirstColunSecondSection_Returns27456()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.FindColumnProduct(0, 3, 3);
            var expected = 52 * 22 * 24;
            Assert.AreEqual(expected, product);
        }
        #endregion

        #region AnalyseColumn Tests
        [TestMethod]
        public void AnalyseColumn_FirstColumn_Returns206388()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 206388; // Verified - (49,81,52)
            var result = analyser.AnalyseColumn(0);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AnalyseColumn_LastColumn_Returns463275()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 463275; // Verified - (75,87,71)
            var result = analyser.AnalyseColumn(9);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region FindLRDiagonalProduct Test
        [TestMethod]
        public void FindLRDiagonalProduct_TopLeftSection_Returns12152()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 8*49*31; 
            var result = analyser.FindLRDiagonalProduct(0, 0, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindLRDiagonalProduct_BottomLeftSection_Returns84755()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 67 * 55 * 23;
            var result = analyser.FindLRDiagonalProduct(7, 0, 3);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region AnalyseLRDiagonalSection Tests
        [TestMethod]
        public void AnalyseLRDiagonalSection_FirstColumn_Returns228095()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 228095; // Verified - (49,49,95)
            var result = analyser.AnalyseLRDiagonalSection(0, 0);
            Assert.AreEqual(expected, result);
        }

        #endregion

        #region FindRLDiagonalProduct Tests
        [TestMethod]
        public void FindRLDiagonalProduct_TopRightSection_Returns130500()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 75 * 60 * 29;
            var result = analyser.FindRLDiagonalProduct(0, 9, 3);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region AnalyseRLDiagonalSection Tests
        [TestMethod]
        public void AnalyseRLDiagonalSection_LastColumn_Returns436011()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var expected = 436011; // Verified - (49,49,95)
            var result = analyser.AnalyseRLDiagonalSection(0, 9);
            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}
