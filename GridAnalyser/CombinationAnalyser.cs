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
         * Make an assumption based current requirements for 10 x 10 grid :
         * Simplify CombinationAnalyser for use with square arrays only?
         **/

        public int adjacentIntegers { get; set; }
        public CombinationAnalyser()
        {
                
        }

        public int HorizontalCombinations(int elementsInRow, int elementsInColumn)
        {

            return ((elementsInRow - adjacentIntegers) + 1) * elementsInColumn;
            
        }

        public int LRDiagonalCombinations(int elementsInRow, int elementsInColumn)
        {
            // Visual analysis -> Hypothesis : square of the difference length of square and adjacent cells - 1
            var result = Math.Pow((elementsInRow - adjacentIntegers + 1), 2);
            return Convert.ToInt32(result);
            
        }

        public int NumberOfCombinationsInASquareArray(int elementsInRow)
        {
            var result = HorizontalCombinations(elementsInRow, elementsInRow) + LRDiagonalCombinations(elementsInRow, elementsInRow);
            return 2 * result;
        }

    }
}
