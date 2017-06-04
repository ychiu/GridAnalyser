using System;
using System.Collections.Generic;
using System.Text;

namespace GridAnalyser
{
    public class CombinationAnalyser
    {
        /**
         * Calculate the different combinations of adjacent numbers in the same direction of a 10 x 10 Grid
         *
         **/

        public int adjacentIntegers { get; set; }
        public CombinationAnalyser()
        {
                
        }


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

        public int HorizontalCombinations(int elementsInRow, int elementsInColumn)
        {
            return (elementsInRow - adjacentIntegers) + 1;
            
        }

        public int VerticalCombinations(int elementsInRow, int elementsInColumn)
        {
            throw new NotImplementedException();
        }

        public int LRDiagonalCombinations(int elementsInRow, int elementsInColumn)
        {
            throw new NotImplementedException();
        }

        public int RLDiagonalCombinations(int elementsInRow, int elementsInColumn)
        {
            throw new NotImplementedException();
        }
    }
}
