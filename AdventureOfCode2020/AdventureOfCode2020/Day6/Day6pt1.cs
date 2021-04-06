using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureOfCode2020
{
    class Day6pt1
    {
        private List<char[]> answerList;

        public Day6pt1()
        {
            answerList = new List<char[]>();
            StringBuilder sb = new StringBuilder();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day6\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line == "")
                {
                    answerList.Add(sb.ToString().Distinct().ToArray());
                    sb.Clear();
                }
                else
                {
                    sb.Append(line);
                }
            }
            if(sb.Length > 0)
            {
                answerList.Add(sb.ToString().Distinct().ToArray());
                sb.Clear();
            }
        }

        internal void exec()
        {
            Console.WriteLine("day 6 - nr of sum answer: " + answerList.Select(a => a.Length).Sum());
        }
    }
}
