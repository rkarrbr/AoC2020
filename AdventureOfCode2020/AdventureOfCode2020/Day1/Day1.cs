using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureOfCode2020
{
    class Day1
    {
        public Day1()
        {

        }

        public void exec()
        {
            string line;
            int maxVal = 0; 
            var list = new List<int>();
            
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day1\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                list.Add(int.Parse(line));
                //System.Console.WriteLine(line);
                //counter++;
            }
            foreach(var x in list)
            {
                foreach(var y in list)
                {
                    if(x != y && x + y == 2020)
                    {
                        if(x * y > maxVal)
                        {
                            maxVal = x * y;
                        }
                    }
                }
            }
            Console.WriteLine("part1:" + maxVal);

            foreach(var x in list)
            {
                foreach(var y in list)
                {
                    foreach(var z in list)
                    {
                        if(x+y+z == 2020)
                        {
                            Console.WriteLine("part2:" + x * y * z);
                            break;
                        }
                    }
                }
            }
        }
    }
}
