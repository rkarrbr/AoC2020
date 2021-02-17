using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureOfCode2020
{
    class Day2
    {
        public Day2() { }

        public void exec()
        {
            string line;
            var list = new List<PasswordPolicy>();

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day2\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                list.Add(new PasswordPolicy(line));
            }

            Console.WriteLine("Number of valid passowrds (pt1): " + list.Where(e => e.part1validate() == true).Count());
            Console.WriteLine("Number of valid passowrds (pt2): " + list.Where(e => e.part2validate() == true).Count());
        }
    }
}
