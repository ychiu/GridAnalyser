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


        //[TestMethod]
        //public void AnalyseRow_FirstRow_ReturnsX()
        //{
        //    GridAnalyser analyser = new GridAnalyser();
        //    analyser.searchGrid = QuExampleGrid;
        //    analyser.AnalyseRow()
        //}
        [TestMethod]
        public void findProduct_FirstRowFirstSection_Returns55290()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.findProduct(0, 0, 3);
            var expected = 8 * 2 * 22;
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void findProduct_FirstRowSecondSection_Returns352()
        {
            GridAnalyser analyser = new GridAnalyser();
            analyser.searchGrid = QuExampleGrid;
            analyser.adjacentIntegers = 3;

            var product = analyser.findProduct(0, 3, 3);
            var expected = 97 * 38 * 15;
            Assert.AreEqual(expected, product);
        }

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
    }
}
