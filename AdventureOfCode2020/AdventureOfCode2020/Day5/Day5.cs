using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureOfCode2020
{
    class Day5
    {
        private List<BoardingPass> boardingPasses;
        public Day5()
        {
            boardingPasses = new List<BoardingPass>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day5\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                boardingPasses.Add(new BoardingPass(line));
            }
        }

        internal void exec()
        {
            Console.WriteLine("Highest seatId (pt1): " + boardingPasses.Select(bp => bp.seatId).Max());

            var seatIds = boardingPasses.Select(p => p.seatId).AsEnumerable();
            HashSet<int> seatId = new HashSet<int>(Enumerable.Range(boardingPasses.Select(bp => bp.seatId).Min(), boardingPasses.Select(bp => bp.seatId).Max()));
            seatId.ExceptWith(seatIds);
            Console.WriteLine("My seatId (pt2): " + seatId.FirstOrDefault());
        }
    }
}