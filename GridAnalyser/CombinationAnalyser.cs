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
