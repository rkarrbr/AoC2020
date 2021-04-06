using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureOfCode2020
{
    internal class Day6pt2
    {
        private List<GroupAnswer> groupAnswers;
        public Day6pt2()
        {
            groupAnswers = new List<GroupAnswer>();
            var currentGroup = new GroupAnswer();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day6\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(line == "")
                {
                    groupAnswers.Add(currentGroup);
                    currentGroup = new GroupAnswer();
                }
                else
                {
                    currentGroup.addAnswer(line);
                }
            }
            groupAnswers.Add(currentGroup);
        }

        internal void exec()
        {
            Console.WriteLine("day 6 - nr of sum common answer (pt2): " + groupAnswers.Select(a => a.currentCommonAnswers.Count).Sum());
        }
    }
}