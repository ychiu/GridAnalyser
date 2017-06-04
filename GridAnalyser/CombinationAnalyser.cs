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

        public int HorizontalCombinations(int elementsInRow, int elementsInColumn)
        {

            return ((elementsInRow - adjacentIntegers) + 1) * elementsInColumn;
            
        }

        public int VerticalCombinations(int elementsInRow, int elementsInColumn)
        {
            throw new NotImplementedException();
        }

        public int LRDiagonalCombinations(int elementsInRow, int elementsInColumn)
        {
            // Visual analysis -> Hypothesis : square of the difference length of square and adjacent cells - 1
            var result = Math.Pow((elementsInRow - adjacentIntegers + 1), 2);
            return Convert.ToInt32(result);
            
        }

        public int RLDiagonalCombinations(int elementsInRow, int elementsInColumn)
        {
            throw new NotImplementedException();
        }
    }
}
