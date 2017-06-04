using System;

namespace GridAnalyserLibrary
{
    public class GridAnalyser
    {
        public GridAnalyser()
        {

        }
        public int adjacentIntegers { get; set; }

        public int[,] searchGrid { get; set; }

        private int maxRowProduct = 0;

        private int maxColumnProduct = 0;

        private int maxDiagonalProduct = 0;


        // Analysis methods
        public long AnalyseRows()
        {
            long maxRowProduct = 0;
            long product = 0;
            // Get number of rows
            var noOfRows = searchGrid.GetLength(0);

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
            var rowLength = searchGrid.GetLength(1);
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
                product = product * searchGrid[rowIndex,i];
            }
            return product;
        }

        public long AnalyseColumns()
        {
            long maxColumnProduct = 0;
            long product = 0;
            // Get number of columns
            var noOfColumns = searchGrid.GetLength(1);

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
            var columnLength = searchGrid.GetLength(0);
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
                product = product * searchGrid[i, columnIndex];
            }
            return product;
        }

        public long AnalyseLRDiagonalSection(int rowIndex, int columnIndex)
        {
            long maxLRDiagonalProduct = 0;
            long product = 0;
            var columnLength = searchGrid.GetLength(0);
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
                product = product * searchGrid[rowIndex + i, columnIndex + i];
            }
            return product;
        }

        public long AnalyseRLDiagonalSection(int rowIndex, int columnIndex)
        {
            long maxRLDiagonalProduct = 0;
            long product = 0;
            var columnLength = searchGrid.GetLength(0);
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
                product = product * searchGrid[rowIndex + i, columnIndex - i];
            }
            return product;
        }


        private int AnalysisLRDiagonals()
        {
            throw new NotImplementedException();
        }

        private int AnalysisRLDiagonals()
        {
            throw new NotImplementedException();
        }

        private int CalculateProduct(int [] integers)
        {
            throw new NotImplementedException();
        }

    }
}
