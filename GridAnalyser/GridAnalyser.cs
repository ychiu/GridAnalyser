﻿using System;
using System.Threading.Tasks;

namespace GridAnalyserLibrary
{
    public class GridAnalyser
    {
        public GridAnalyser()
        {

        }
        public int adjacentIntegers { get; set; }

        public int[][] searchGrid { get; set; }

        // Analysis methods

        public long AnalyseRows()
        {
            long maxRowProduct = 0;
            long product = 0;
            // Get number of rows
            var noOfRows = searchGrid.Length;

            for (int i = 0; i < noOfRows; i++)
            {
                product = AnalyseRow(i);
                maxRowProduct = (maxRowProduct < product) ? product : maxRowProduct;
            }
            return maxRowProduct;
        }
        public long AnalyseRow(int rowIndex)
        {
            long maxRowProduct = 0;
            long product = 0;
            var rowLength = searchGrid[0].Length;
            for (int i = 0; i < rowLength - adjacentIntegers; i++)
            {
                product = FindRowProduct(rowIndex, i, adjacentIntegers);
                maxRowProduct = (maxRowProduct < product) ? product : maxRowProduct;
            }
            return maxRowProduct;
        }
        
        public long FindRowProduct(int rowIndex, int startIndex,int adjacentInts)
        {
            long product = 1;
            for(int i = startIndex; i < startIndex + adjacentInts; i++)
            {
                product = product * searchGrid[rowIndex][i];
            }
            return product;
        }

        public long AnalyseColumns()
        {
            long maxColumnProduct = 0;
            long product = 0;
            // Get number of columns
            var noOfColumns = searchGrid[0].Length;

            for (int i = 0; i < noOfColumns; i++)
            {
                product = AnalyseColumn(i);
                maxColumnProduct = (maxColumnProduct < product) ? product : maxColumnProduct;
            }
            return maxColumnProduct;
        }


        public long AnalyseColumn(int columnIndex)
        {
            long maxColumnProduct = 0;
            long product = 0;
            var columnLength = searchGrid.Length;
            for (int i = 0; i < columnLength - adjacentIntegers; i++)
            {
                product = FindColumnProduct(columnIndex, i, adjacentIntegers);
                maxColumnProduct = (maxColumnProduct < product) ? product : maxColumnProduct;
            }
            return maxColumnProduct;
        }

        public long FindColumnProduct(int columnIndex, int startIndex, int adjacentInts)
        {
            long product = 1;
            for (int i = startIndex; i < startIndex + adjacentInts; i++)
            {
                product = product * searchGrid[i][columnIndex];
            }
            return product;
        }

        public long AnalyseLRDiagonals()
        {
            long maxLRDiagonalsProduct = 0;
            long product = 0;
            // Get number of columns
            var noOfColumns = searchGrid[0].Length;
            for (int i = 0; i < noOfColumns - adjacentIntegers; i++)
            {
                product = AnalyseLRDiagonalSection(0,i); // Vary columns
                maxLRDiagonalsProduct = (maxLRDiagonalsProduct < product) ? product : maxLRDiagonalsProduct;
            }
            return maxLRDiagonalsProduct;

        }

        public long AnalyseLRDiagonalSection(int rowIndex, int columnIndex)
        {
            long maxLRDiagonalProduct = 0;
            long product = 0;
            var columnLength = searchGrid.Length;
            for (int i = 0; i < columnLength - adjacentIntegers; i++)
            {
                product = FindLRDiagonalProduct(rowIndex + i, columnIndex, adjacentIntegers);
                maxLRDiagonalProduct = (maxLRDiagonalProduct < product) ? product : maxLRDiagonalProduct;
            }
            return maxLRDiagonalProduct;
        }


        public long FindLRDiagonalProduct(int rowIndex, int columnIndex, int adjacentInts)
        {
            // HINT - var row = QuExampleGrid[0,9]; // 75 (1st row, 10th element
            long product = 1;
            for (int i = 0; i < adjacentInts; i++)
            {
                product = product * searchGrid[rowIndex + i][columnIndex + i];
            }
            return product;
        }

        public long AnalyseRLDiagonals()
        {
            long maxRLDiagonalsProduct = 0;
            long product = 0;
            // Get number of columns
            var noOfColumns = searchGrid[0].Length;
            for (int i = noOfColumns -1; i >= (adjacentIntegers - 1) ; i--)
            {
                product = AnalyseRLDiagonalSection(0, i); // Vary columns
                maxRLDiagonalsProduct = (maxRLDiagonalsProduct < product) ? product : maxRLDiagonalsProduct;
            }
            return maxRLDiagonalsProduct;
        }

        public long AnalyseRLDiagonalSection(int rowIndex, int columnIndex)
        {
            long maxRLDiagonalProduct = 0;
            long product = 0;
            var columnLength = searchGrid.Length;
            for (int i = 0; i < columnLength - adjacentIntegers; i++)
            {
                product = FindRLDiagonalProduct(rowIndex + i, columnIndex, adjacentIntegers);
                maxRLDiagonalProduct = (maxRLDiagonalProduct < product) ? product : maxRLDiagonalProduct;
            }
            return maxRLDiagonalProduct;
        }


        public long FindRLDiagonalProduct(int rowIndex, int columnIndex, int adjacentInts)
        {
            // HINT - var row = QuExampleGrid[0,9]; // 75 (1st row, 10th element
            long product = 1;
            for (int i = 0; i < adjacentInts; i++)
            {
                product = product * searchGrid[rowIndex + i][columnIndex - i];
            }
            return product;
        }

        public long largestProductOfNAdjacentIntegersNonAsync(int[][] searchGrid, int adjacentIntegers)
        {
            // Clear state
            this.adjacentIntegers = adjacentIntegers;
            this.searchGrid = searchGrid;
            // Execute search
            var maxRowProduct = AnalyseRows();
            var maxColumnProduct = AnalyseColumns();
            var maxLRDiagonalProduct = AnalyseLRDiagonals();
            var maxRLDiagonalProduct = AnalyseRLDiagonals();
            // Process Results
            var maxProduct = findMaximumValue(maxRowProduct, maxColumnProduct, maxLRDiagonalProduct, maxRLDiagonalProduct);
            return maxProduct;
        }

        #region Parallelism Functional Extensions

        private async Task<long> AnalyseRowsAsync()
        {
            return AnalyseRows();
        }

        private async Task<long> AnalyseColumnsAsync()
        {
            return AnalyseColumns();
        }

        private async Task<long> AnalyseLRDiagonalsAsync()
        {
            return AnalyseLRDiagonals();
        }

        private async Task<long> AnalyseRLDiagonalsAsync()
        {
            return AnalyseRLDiagonals();
        }

        private async Task<long> AnalyseAllAsync()
        {
            Task<long>[] tasks = new Task<long>[4];
            tasks[0] = Task.Run(()=> AnalyseRowsAsync());
            tasks[1] = Task.Run(() => AnalyseColumnsAsync());
            tasks[2] = Task.Run(() => AnalyseLRDiagonalsAsync());
            tasks[3] = Task.Run(() => AnalyseRLDiagonalsAsync());
            var result = Task.WhenAll(tasks);
            var maxProduct = findMaximumValue(result.Result[0], result.Result[1], result.Result[2], result.Result[3]);
            return maxProduct;
        }


        private long findMaximumValue(long rows, long cols, long lr, long rl)
        {
            var maxProduct = (rows > cols) ? rows : cols;
            maxProduct = (maxProduct > lr) ? maxProduct : lr;
            maxProduct = (maxProduct > rl) ? maxProduct : rl;
            return maxProduct;
        }

        public long largestProductOfNAdjacentIntegers(int[][] searchGrid, int adjacentIntegers)
        {
            // Clear state
            this.adjacentIntegers = adjacentIntegers;
            this.searchGrid = searchGrid;
            // Execute async search
            var result = AnalyseAllAsync();

            return result.Result;
        }
        #endregion

    }
}
