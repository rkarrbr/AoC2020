using System;

namespace AdventureOfCode2020
{
    internal class BoardingPass
    {
        public string binarySpacePartitioning { get; private set; } // 7 (F/B) - 3 (L/R)
        public int seatId { get; private set; }

        public BoardingPass(string binarySpacePartitioning)
        {
            this.binarySpacePartitioning = binarySpacePartitioning;
            this.seatId = calculateSeatID(this.binarySpacePartitioning, 0, 127, 0, 7);
        }

        private int calculateSeatID(string binarySpacePartitioning, int rowLo, int rowHi, int colLo, int colHi)
        {
            switch (binarySpacePartitioning[0])
            {
                case 'F': //front, the lower part
                    rowHi = rowHi - ((rowHi - rowLo + 1)) / 2;
                    break;
                case 'B': //back, the higer part
                    rowLo = ((rowHi - rowLo + 1) / 2) + rowLo;
                    break;
                case 'L': //left side, lower part
                    colHi = colHi - ((colHi - colLo + 1) / 2);
                    break;
                case 'R': //right side, higher part
                    colLo = ((colHi - colLo + 1 )) / 2 + colLo;
                    break;
                default:
                    break;
            }

            if(colLo == colHi)
            {
                return rowLo * 8 + colLo;
            }
            if(rowLo == rowHi)
            {
                return calculateSeatID(binarySpacePartitioning.Substring(1, binarySpacePartitioning.Length-1), rowLo, rowHi, colLo, colHi);
            }
            return calculateSeatID(binarySpacePartitioning.Substring(1, binarySpacePartitioning.Length-1), rowLo, rowHi, colLo, colHi);
        }
    }
}