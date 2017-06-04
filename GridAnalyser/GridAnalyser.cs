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
        private int AnalyseRows()
        {
            // Get number of rows
            var iRows = searchGrid.GetLength(0);
            var iColumns = searchGrid.GetLength(1);

            return 0;


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


        public long FindLRDiagonalProduct(int rowIndex, int columnIndex, int adjacentInts)
        {
            // HINT - var row = QuExampleGrid[0,9]; // 75 (1st row, 10th element
            long product = 1;
            for (int i = 0; i < adjacentInts; i++)
            {
                product = product * searchGrid[rowIndex + i, columnIndex+ i];
            }
            return product;
        }

        private int AnalyseColumns()
        {
            throw new NotImplementedException();
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
