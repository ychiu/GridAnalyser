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
                product = findProduct(rowIndex, i, adjacentIntegers);
                maxRowProduct = (maxRowProduct < product) ? product : maxRowProduct;
            }
            return maxRowProduct;
        }
        
        public long findProduct(int rowIndex, int startIndex,int adjacentInts)
        {
            long product = 1;
            for(int i = startIndex; i < startIndex + adjacentInts; i++)
            {
                product = product * searchGrid[rowIndex,i];
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
