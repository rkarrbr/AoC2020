using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureOfCode2020
{
    internal class GroupAnswer
    {
        public HashSet<char> currentCommonAnswers { get; private set; }

        public GroupAnswer(){}

        internal void addAnswer(string newAnswers)
        {
            if(currentCommonAnswers == null)
            {
                currentCommonAnswers = new HashSet<char>(newAnswers.ToArray());
            }
            else
            {
                var intersect = new HashSet<char>(newAnswers.ToArray());
                currentCommonAnswers.IntersectWith(intersect);
            }
        }
    }
}